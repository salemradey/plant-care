using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class NurseryStocker : MonoBehaviour
{
    // Start is called before the first frame update
    string[] plantTypes = { "Pothos", "SnakePlant", "AloeVera", "SpiderPlant" };
    int count = 0;

    public GameObject[] plantObj;
    public Sprite[] spriteList;

    void Start()
    {
        for(int i = 0; i < plantTypes.Length; i++)
        {
            if (PlayerPrefs.GetInt("Owned" + plantTypes[i]) == 1)
            {
                plantObj[count].SetActive(true);
                plantObj[count].GetComponent<Image>().sprite = spriteList[i];
                count++;
            }
        }
    }

}
