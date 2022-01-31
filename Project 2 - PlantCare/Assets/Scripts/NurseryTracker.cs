using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


    public class NurseryTracker : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            if(PlayerPrefs.GetInt("Owned"+ gameObject.name) == 1 )
            {
                Debug.Log(gameObject.name + " already exists in nursery");
            }

            else
            {
                PlayerPrefs.SetInt(("Owned" + gameObject.name), 1);
                PlayerPrefs.Save();
            Debug.Log("new plant: " + gameObject.name + " detected. Added to nursery.");
            }
        }

    }
