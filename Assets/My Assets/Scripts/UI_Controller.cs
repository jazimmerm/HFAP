using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : MonoBehaviour
{
    public GameObject kenyaUI;
    public GameObject ghanaUI;
    public GameObject botswanaUI;
    public GameObject kenyaButton;
    public GameObject ghanaButton;
    public GameObject botswanaButton;

    string btnName;

    // Start is called before the first frame update
    void Start()
    {
        kenyaUI.SetActive(false);
        ghanaUI.SetActive(false);
        botswanaUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        btnName = Hit.transform.name;
        switch (btnName)
                {
                    case "kenyaButton":
                    kenyaUI.SetActive(true);
                    break;
                    default:
                    break;
                }
          
       
    }
}