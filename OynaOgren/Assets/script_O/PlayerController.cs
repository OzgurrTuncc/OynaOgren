using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 4f;
    public float gravity = -15f;
    public float velocity = 1f;
    public Rigidbody rgb3d;

    private Vector3 gravityVector;
    //GroundCheeck
    public Transform groundCheckPoint;
    public float groundCheckRadius = 0.35f;
    public LayerMask groundLayer;

    public bool isGrounded;

    public float jumpSpeed = 0.05f;


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
        if (isGrounded && gravityVector.y < 0)
        {
            gravityVector.y = -3f;
        }

        if(Input.GetButtonDown("Jump") && isGrounded) 
        {
            gravityVector.y = jumpSpeed;
        }


    }
}
