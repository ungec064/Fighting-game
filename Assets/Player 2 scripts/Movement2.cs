using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    Hit_2 H;
    Rigidbody rb;
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
    public float DamageCooldown = 0;
    Collider m_ObjectCollider;


    private void OnCollisionStay(Collision collision)
    {
        stance = 0;
        airstance = 0;
    }
    private void OnCollisionExit(Collision collision)
    {
        stance = 1;
    }
    private void OnTriggerExit(Collider ground)
    {
        m_ObjectCollider.isTrigger = false;
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        H = GetComponent<Hit_2>();
        m_ObjectCollider = GetComponent<Collider>();
    }




    void Update()
    {
        //right
        if (Input.GetKey(KeyCode.D))
        {


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
        if (Input.GetKey(KeyCode.A))
        {


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

        }

        //jump
        if (Input.GetKeyDown(KeyCode.W) && (stance < 2))
        {
            rb.velocity = new Vector3(0, jumpspeed, 0);
            stance = stance + 1;
            m_ObjectCollider.isTrigger = true;
        }

        if (stance == 2)
        {
            m_ObjectCollider.isTrigger = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            m_ObjectCollider.isTrigger = true;

        }

        //Damage and Death
        if (H.TakeDamage == 1)
        {
            if (DamageCooldown == 0)
                Health = Health - 5;
            DamageCooldown = 20;
        }

        if (DamageCooldown > 0)
        {
            DamageCooldown = 1;
        }

        if (Health == 0)
        {
            Destroy(gameObject);
        }

    }
}