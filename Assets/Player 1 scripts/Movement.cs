using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    GameObject ground;
    Rigidbody rb;
    Collider m_ObjectCollider;
    public float speed = 4.0f;
    public float jumpspeed = 1.0f;
    public float Health = 100;
    public float stance = 0;
    public float airstance = 0;
    public float halfspeed = 2.0f;
    public float lowestspeed = 1.0f;
    public float left = 0;
    public float right = 0;
    public float down = 0;
    public float up = 0;
    public float fallingThrough = 0;
    public float grounded = 0;
    public float time = 1;
    public Vector3 Position;
    public float timeGoingThrough = 0f;
    //The collision and trigger stuff


    private void OnCollisionStay(Collision collision)
    {
        stance = 0;
        airstance = 0;
    }
    private void OnCollisionExit(Collision collision)
    {
        stance = 1;

    }
    private void OnCollisionEnter(Collision collision)
    {

    }


    private void OnTriggerEnter(Collider ground)
    {

    }
    private void OnTriggerExit(Collider other)
    {
        m_ObjectCollider.isTrigger = false;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        m_ObjectCollider = GetComponent<Collider>();
    }




    void Update()
    {


        //right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Position = rb.position;

            if (stance < 1)
            {
                rb.velocity = new Vector3(speed, 0, 0);
            }

            if ((stance > 0) && (airstance < 29))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                airstance = airstance + 2;
            }
            if ((stance > 0) && (airstance < 40) && (airstance > 29))
            {
                rb.velocity = new Vector3(halfspeed, -2, 0);
                airstance = airstance + 2;
            }
            if ((stance > 0) && (airstance > 39))
            {
                rb.velocity = new Vector3(lowestspeed, -3, 0);
                airstance = airstance + 1;
            }
        }

        //left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            left = 1;
            Position = rb.position;
            if (stance < 1)
            {
                rb.velocity = new Vector3(-speed, 0, 0);
            }

            if ((stance > 0) && (airstance < 29))
            {
                rb.velocity = new Vector3(-speed, 0, 0);
                airstance = airstance + 2;
            }
            if ((stance > 0) && (airstance < 40) && (airstance > 29))
            {
                rb.velocity = new Vector3(-halfspeed, -2, 0);
                airstance = airstance + 2;
            }
            if ((stance > 0) && (airstance > 39))
            {
                rb.velocity = new Vector3(-lowestspeed, -3, 0);
                airstance = airstance + 1;
            }



        }

        //none
        if (Input.GetKey(KeyCode.None))
        {
            rb.velocity = new Vector3(0, 0, 0);
            Position = rb.position;

        }

        //jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && (stance < 2))
        {
            Position = rb.position;
            rb.velocity = new Vector3(0, jumpspeed, 0);
            stance = stance + 1;
           
        }
        if (Input.GetKey(KeyCode.UpArrow)) { 
           
            m_ObjectCollider.isTrigger = true;
            
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            timeGoingThrough = 0.1f;
        }

        if (stance == 2){
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Position = rb.position;
            m_ObjectCollider.isTrigger = true;
            timeGoingThrough = 0.2f;
        }
        if(timeGoingThrough < 0)
        {
            m_ObjectCollider.isTrigger = false;
        }

        if(timeGoingThrough > 0)
        {
            timeGoingThrough = timeGoingThrough - Time.deltaTime;
            
        }

    }
}  
