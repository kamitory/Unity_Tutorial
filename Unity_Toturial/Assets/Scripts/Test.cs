using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    ParticleSystem ps;

    void Start()
    {
      
    }
    
   void Update()
    {
        ps.Emit(100);
    }


}
