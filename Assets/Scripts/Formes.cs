using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formes : MonoBehaviour
{
    public string nom;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            DisplayText();
        }
    }

    //polymorphisme
    public virtual void DisplayText()
    {
        Debug.Log("je suis " + nom);
    }
}
