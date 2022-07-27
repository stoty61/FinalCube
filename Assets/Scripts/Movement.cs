using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public Transform player;

    public float sidewaysForce = 2000f;

    public float forwardForce = 1000f;

    public float jumpForce = 10f;

    public float bounceForce; 

    bool jumping = false;
    

    //grounded boolean
    bool grounded = false;

    //up arrow boolean
    bool up = false;

    //right arrow boolean
    bool right = false;

    //left arrow boolean
    bool left = false;

    //is called at the beginning 
    void Start() 
    {
        rb.freezeRotation = true;
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }

        if (collision.gameObject.CompareTag("Bounce"))
        {
            Debug.Log("should be jumping");
            jumping = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }

    // Update is called once per frame, used for physics 
    void FixedUpdate()
    {

        //forward force 
        rb.AddForce(0,0, Time.deltaTime * forwardForce);

        //left arrow input 
        if (left)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime * -1 ,0, 0, ForceMode.VelocityChange);
        }

        //right arrow input 
        if (right)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime ,0, 0, ForceMode.VelocityChange);
        }

        //up arrow input
        if (up)
        {
            rb.AddForce(0 ,jumpForce, 0);
            up = false;
        }

        if (jumping)
        {
            rb.AddForce(0, bounceForce, 0);
            jumping = false;
        }

    }

    //update called once per frame 
    void Update()
    {
        //up arrow input 
        if (Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.W))
        {
            if (grounded == true)
            {
                up = true;
            } 
        }

        //left arrow input 
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            left = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow)|| Input.GetKeyUp(KeyCode.A))
        {
            left = false;
        }

        //right arrow input 
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            right = true;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow)|| Input.GetKeyUp(KeyCode.D))
        {
            right = false;
        }

    }
}
