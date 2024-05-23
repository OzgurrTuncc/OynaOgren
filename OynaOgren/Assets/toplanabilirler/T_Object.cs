using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class T_Object : MonoBehaviour
{
    private Rigidbody rb;
    public bool taken = false;

    [HideInInspector]
    public bool hasReseted = false;

    private GameObject pivot;
    private Camera mainCamera;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pivot = GameObject.FindGameObjectWithTag("pivot");
        mainCamera = Camera.main;

        if (pivot == null)
        {
            Debug.LogWarning("Pivot nesnesi bulunamadý. Sahneye 'pivot' etiketi olan bir nesne eklediðinizden emin olun.");
        }

        if (mainCamera == null)
        {
            Debug.LogWarning("Ana Kamera bulunamadý. Sahneye 'MainCamera' etiketi olan bir Kamera eklediðinizden emin olun.");
        }
    }

    private void Update()
    {
        if (taken)
        {
            MoveToPivot();
        }
        else
        {
            rb.useGravity = true;
        }

        if (!hasReseted)
        {
            ResetForce();
            hasReseted = true;
        }
    }

    private void MoveToPivot()
    {
        if (pivot != null)
        {
            rb.MovePosition(pivot.transform.position);
            if (mainCamera != null)
            {
                rb.MoveRotation(Quaternion.LookRotation(mainCamera.transform.forward));
            }
            rb.useGravity = false;
        }
    }

    public void ResetForce()
    {
        rb.isKinematic = true;
        rb.isKinematic = false;
    }

    public void Force()
    {
        if (mainCamera != null)
        {
            rb.AddForce(mainCamera.transform.forward, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        taken = false;
    }
}
