using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//heritage
public class Cube : Formes
{
    //private string color;
    private string nomCube = "cube";

   
    //encapsulation
    public string Nom { get => nomCube; set => nomCube = value; }   

    public override void DisplayText()
    {
        displayText.text = "je suis un " + Nom + " de couleur " + couleur.color;
        //Debug.Log(displayText);
    }
}
