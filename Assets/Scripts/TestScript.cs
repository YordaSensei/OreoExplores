using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SearchService;

public class TestScript : MonoBehaviour
{
    //public GameObject cube;
    //public int x, y, z;
    //public GameObject scene_1,scene_2,scene_3, scene_4;

    public GameObject[] Scenes;
    //which scene should be active
    public int ActiveScene; 
    // Start is called before the first frame update
    void Start()
    {
        // cube.transform.localScale = new Vector3(x, y, z);
        //scene_1.SetActive(true);
        Scenes[0].SetActive(true);
    }


    
    // Update is called once per frame
    void Update()
    {
        //for scale
        //cube.transform.localScale = new Vector3(x, y, z);
        //for position
        //cube.transform.localPosition = new Vector3(x, y, z);

        SceneChanger();

    }
    
    public void SceneChanger()
    {
        for (int i = 0; i < Scenes.Length; i++)
        {
            //= : declare or assigning values, == validation and checking
            Scenes[i].SetActive(i == ActiveScene);
            //ActiveScene = 2
            //All Scene except 2 will be Active = True and else Active = false;
            //Scene[99].SetActive(i == 2);
        }
    }
    public void StartButton()
    {
        ActiveScene = 1;
    }

    public void ExploreTheCity()
    {
        ActiveScene = 2;
    }

    public void GoToFamily()
    {
        ActiveScene = 3;
    }

    public void GrowlAtTheKids()
    {
        ActiveScene = 4;
    }
}
