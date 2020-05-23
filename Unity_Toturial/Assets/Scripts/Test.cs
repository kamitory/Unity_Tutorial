using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Animation anim;


    void Start()
    {
        anim = GetComponent<Animation>(); 
    }
    
   void Update()
    {
       if (Input.GetKeyDown(KeyCode.W))
        {
           // anim.Play("New_Animation2");
           // anim.PlayQueued("New_Animation2");
           anim.Blend("New_Animation2");
           // anim.CrossFade("New_Animation2");
           // if (anim.IsPlaying("New_Animation2"))
           //     anim.Play("New_Animation2");
        }
    }


    
}
