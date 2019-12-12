using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_2 : MonoBehaviour
{ 
public bool attackleft_2 = false;
public float attackTimer = 0.0f;
public float PlayPartical = 0;
void Start()
{

}

// Update is called once per frame

void Update()
{

    if (Input.GetKeyDown(KeyCode.Space))
    {

        if (attackTimer < .001)
        {
            attackleft_2 = true;
            attackTimer = 1.0f;
            PlayPartical = 1;

        }


    }
    if (Input.GetKey(KeyCode.Mouse0) == false)
    {
        attackleft_2 = false;
        PlayPartical = 0;

    }

    if (attackTimer > 0)
    {
        attackTimer = attackTimer - Time.deltaTime;
    }

}

    

}