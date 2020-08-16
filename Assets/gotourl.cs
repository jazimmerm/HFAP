using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotourl : MonoBehaviour
{

    public string url;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        Application.OpenURL( url);
    }

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
