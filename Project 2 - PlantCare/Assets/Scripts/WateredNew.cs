using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace WaterTime
{
    class WateredNew : MonoBehaviour

    {
        // Start is called before the first frame update
        private string waterDate;
        void OnEnable()
        {
        }

        void OnGUI()
        {
            GUIStyle mystyle = new GUIStyle(GUI.skin.label);
            Font myfont = (Font)Resources.Load("Fonts/Lato-Regular", typeof(Font));
            mystyle.font = myfont;
            mystyle.fontStyle = FontStyle.Italic;
            mystyle.normal.textColor = Color.grey;

            if (PlayerPrefs.GetString("Watered" + gameObject.name).Length > 1)
            {
                mystyle.fontSize = 20;
                waterDate = PlayerPrefs.GetString("Watered" + gameObject.name);
                waterDate = GUI.TextField(new Rect(133, 36, 200, 50), waterDate, mystyle);
            }

            else
            {
                mystyle.fontSize = 16;
                waterDate = GUI.TextField(new Rect(133, 39, 200, 50), "Click Watering Can to Water!", mystyle);
            }

            


        }
        public void SaveWatered()
        {
            waterDate = System.DateTime.Now.ToString("MM/dd");
            PlayerPrefs.SetString("Watered" + gameObject.name, waterDate);
            PlayerPrefs.Save(); 
            Debug.Log("saved " + gameObject.name);
        }

    }
}
