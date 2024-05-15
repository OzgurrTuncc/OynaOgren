using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "door")
        {
            Animator animator = other.GetComponentInChildren<Animator>();
            animator.SetTrigger("open_close");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "door")
        {
            Animator animator = other.GetComponentInChildren<Animator>();
            animator.SetTrigger("open_close");

        }

    }




}
