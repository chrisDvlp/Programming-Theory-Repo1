using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Formes : MonoBehaviour
{
    public string nom;
    public ChangeMaterial couleur;
    public Text displayText;
    
    // Start is called before the first frame update
    void Start()
    {
        DisplayText();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //{
            //DisplayText();
        //}
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DisplayText();
        }
    }

    //polymorphisme
    public virtual void DisplayText()
    {
        displayText.text = "je suis " + nom + " de couleur " + couleur.ChangeColor(couleur.color);       
        //Debug.Log(displayText);
    }
}
