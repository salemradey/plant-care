using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class PlantInfo : MonoBehaviour
{
    public Button plantObj;
    public GameObject SnakePlantInfoPanel;
    public GameObject PothosInfoPanel;
    public GameObject AloeVeraInfoPanel;
    // Start is called before the first frame update
    void Start()
    {
        plantObj.onClick.AddListener(LoadPlantInfo);
    }

    public void LoadPlantInfo()
    {
        if (plantObj.GetComponent<Image>().sprite.name == "SnakePlantinPot_0")
        {
            SnakePlantInfoPanel.SetActive(true);
        }

        if (plantObj.GetComponent<Image>().sprite.name == "PothosInPot_0")
        {
           PothosInfoPanel.SetActive(true);
        }

        if (plantObj.GetComponent<Image>().sprite.name == "AloeVeraInPot_0")
        {
            AloeVeraInfoPanel.SetActive(true);
        }
    }
}