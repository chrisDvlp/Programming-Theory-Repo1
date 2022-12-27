using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    [SerializeField]
    private Material [] myMaterials;
 
    [SerializeField]
    private MeshRenderer meshRenderer; 

    public string color;
 
    void Start()
    { 
        //assigne une couleur aleatoire
        ChangeColor();
        color = ChangeColor(meshRenderer.material.name);
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor();
            color = ChangeColor(meshRenderer.material.name);
        }
    }

    //abstraction
    public string ChangeColor(string c)
    {   
        return c;
    }

    public void ChangeColor()
    {
        //change couleur aleatoirement
        meshRenderer.material = myMaterials[Random.Range(0,myMaterials.Length)];
    }



    private void OnMouseEnter() 
    { 
    //    ChangeColor();
    }
}
