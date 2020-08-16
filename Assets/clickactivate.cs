using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickactivate : MonoBehaviour
{
    public GameObject Pedestale;
    // Start is called before the first frame update

    void OnMouseDown()
    {
        Pedestale.SetActive(!Pedestale.activeSelf);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
