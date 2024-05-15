using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 2.5f;
    public float gravity = -15f;

    private Vector3 gravityVector;


    //GroundCheck
    public Transform groundCheckPoint;
    public float groundCheckRadius = 0.35f;
    public LayerMask groundLayer;

    public bool isGrounded = false;
    public float jumpSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 moveVector = Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical") * transform.forward;

       characterController.Move(moveVector * speed * Time.deltaTime);

        gravityVector.y += gravity * Time.deltaTime;

        characterController.Move(gravityVector * Time.deltaTime);

        isGrounded = Physics.CheckSphere(groundCheckPoint.position, groundCheckRadius, groundLayer); 

        if (isGrounded = true && gravityVector.y < 0)
        {
            gravityVector.y = -3f;
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {

            gravityVector.y = Mathf.Sqrt(jumpSpeed * -0.3f * gravity);
            //gravityVector.y = jumpSpeed;
        }
    }
}
