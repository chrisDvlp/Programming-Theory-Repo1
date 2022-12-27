using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//heritage
public class Cube : Formes
{
    
    private string nomCube = "cube";

    //encapsulation
    public string Nom { get => nomCube; private set => nomCube = value; }   

    public override void DisplayText()
    {
        Debug.Log("je suis un " + Nom);
    }
}
