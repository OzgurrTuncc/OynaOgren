using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasyonkod : MonoBehaviour
{
    Animator animator;

    

    // Start is called before the first frame update
    void Start()
    {
        animator =GetComponent<Animator>();
       
    }

    // Update is called once per frame
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
