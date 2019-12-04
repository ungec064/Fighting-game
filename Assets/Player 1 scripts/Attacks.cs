using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    public bool attackleft = false;
    public float attackTimer = 0.0f;
    public bool PlayPartical = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        PlayPartical = false;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            if (attackTimer < 1) {
                attackleft = true;
                attackTimer = 1.0f;
                PlayPartical = true;
            }
        }
        if (Input.GetKey(KeyCode.Mouse0) == false)
        {
            attackleft = false;
        }

        if (attackTimer > 0) {
            attackTimer = attackTimer - Time.deltaTime;
        }

    }

    

    }

