using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OpenURL : MonoBehaviour
{
    public string url;
    public Button buttonObj;
    // Start is called before the first frame update
    void Start()
    {
        buttonObj.onClick.AddListener(OpenLink);
    }

    public void OpenLink()
    {
        Application.OpenURL(url);
    }


}
