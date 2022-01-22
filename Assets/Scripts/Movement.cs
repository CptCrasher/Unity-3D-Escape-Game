using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Instantiating public variables
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    // Update is called once per frame
    void Update()
    {
        //Checks if toching layer 'ground'
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //if touching ground layer and velocity is decreased, set velocity to 2f
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -10f;
        }

        //Getting keyboard inputs
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Apply keyboard inputs to character controller
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //Calculates the amount of velocity needed in the y axis to achieve desired jump height
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //Establishes gravity 
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
