using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    [SerializeField]
    private Material [] myMaterials;
 
    [SerializeField]
    private MeshRenderer meshRenderer; 
 
    void Start()
    { 
        //assigne une couleur aleatoire
        ChangeColor();
    }

    //private void Update() 
    //{
    //    if(Input.GetKeyDown(KeyCode.Space))
    //    {
    //        ChangeColor();
    //    }
    //}

    //abstraction
    public void ChangeColor()
    {
        meshRenderer.material = myMaterials[Random.Range(0,myMaterials.Length)];
       //Debug.Log(meshRenderer.material.name);
    }



    private void OnMouseEnter() 
    { 
        ChangeColor();
    }
}
