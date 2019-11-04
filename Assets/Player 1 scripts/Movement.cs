using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 4.0f;
    public float jumpspeed = 1.0f;
    public float Health = 100;
    public float stance = 0;
    public float airstance = 0;
    public float halfspeed = 2.0f;
    public float lowestspeed = 1.0f;
    private void OnCollisionStay(Collision collision)
    {
        stance = 0;
        airstance = 0;
    }




    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }




    void Update()
    {
        //right
        if (Input.GetKey(KeyCode.RightArrow)){


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


            if(stance < 1) {
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

        }

        //jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && (stance < 2))
        {
            rb.velocity = new Vector3(0, jumpspeed, 0);
            stance = stance + 1;
        }


    }
}