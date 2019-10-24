using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 4.0f;
    public float Health = 100;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -transform.right * speed;
        }
        if (Input.GetKey(KeyCode.None))
        {
            rb.velocity = transform.right * 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = transform.up * speed;
        }
    }
}
