using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab;
 
    void Start()
    {
    
    }

    void Update()
    {
        SpawnAtMousePos();
    }

    void SpawnAtMousePos()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //instancier un prefab cube a la position de la souris
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Debug.Log(hit.point);
                Vector3 position = new Vector3(hit.point.x, hit.point.y+objectPrefab.transform.position.y,hit.point.z);
                Instantiate(objectPrefab, position, transform.rotation);
            }        
        }
    }
}
