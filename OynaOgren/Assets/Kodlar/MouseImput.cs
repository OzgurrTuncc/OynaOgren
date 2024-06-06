using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseImput : MonoBehaviour
{
    public Transform player;
    public float mouseSens = 25f;

    private float xRotation;


    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    void Update()
    {
        float mouseXPos = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseYPos = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= mouseYPos;

        xRotation = Mathf.Clamp(xRotation, -80f, 55f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

       

        player.Rotate(Vector3.up * mouseXPos);


    }
}
