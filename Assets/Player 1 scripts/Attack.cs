using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject attack;
    Rigidbody rb;

    void Start()
    {

    }


    void Update()
    {

        if (left > 0)
        {
            Instantiate(attack, new Vector3(rb.position.x -5 , rb.position.y, rb.position.z), transform.rotation);
        }

    }
}
