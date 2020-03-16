using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public GameObject player;
    public CharacterController controller;
    public float speed = 12.0f;
    //private float gravity = -9.18f;
   // public Vector3 velocity;

    public Transform GroundCheck;
    public float groundDistance = 0.4f;//radius of sphere to check
    public LayerMask groundMask;//control what objects to check
    //bool isGrounded;
                                

    private float y;
    //private float x;
    //private float z;

    void Start()
    {
        y = controller.transform.position.y;
    }


    void Update()
    {
       // isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);
       // Vector3 temp = controller.transform.position;

        float mouseX = Input.GetAxis("Horizontal");
        float mousez = Input.GetAxis("Vertical");
        Vector3 move = transform.right * mouseX + transform.forward * mousez;//direct it in the right direction

        controller.Move(move * speed * Time.deltaTime);
        


        //velocity.y += gravity * Time.deltaTime;
        //controller.Move(velocity * Time.deltaTime);

        /* if (isGrounded)
         {
             
         }*/



        /*
        if (Input.GetKey("up"))
        {

            player.transform.position += new Vector3(0, 0, 0.2f);
        }
        if (Input.GetKey("down"))
        {
          player.transform.position -= new Vector3(0, 0, 0.2f);
        }

        if (Input.GetKey("left"))
        {

            player.transform.position -= new Vector3(0.2f, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            player.transform.position += new Vector3(0.2f, 0, 0);
        }*/

    }
}
