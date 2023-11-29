using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetsTransforms : MonoBehaviour
{
    public Vector3 yon;

    
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(yon);
    }
}
