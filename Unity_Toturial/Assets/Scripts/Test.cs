using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private Material violet_Mat;
    [SerializeField]
    private Material bluegreen_Mat;

    private MeshRenderer mesh;

    //Vector3 rotation;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }
    
   void Update()
    {
        if(Input.GetMouseButton(0))
        {
            mesh.material = bluegreen_Mat;
        }
        else
        {
            mesh.material = violet_Mat;

        }
    }


    
}
