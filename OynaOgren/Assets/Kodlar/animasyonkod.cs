using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasyonkod : MonoBehaviour
{
    Animator animator;

    

    
    void Start()
    {
        animator =GetComponent<Animator>();
       
    }

    
    void Update()
    {
        bool yuruyorsa = animator.GetBool("yuruyor");
        bool yurumeyebasildi = Input.GetKey("w");

        if (!yuruyorsa && yurumeyebasildi)
        {
            animator.SetBool("yuruyor", true);
        }
        if (yuruyorsa && !yurumeyebasildi)
        { 
            animator.SetBool("yuruyor", false);
        }
    }
}
