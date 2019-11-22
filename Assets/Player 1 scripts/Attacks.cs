using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    public bool attackleft = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attackleft = true;
        }
        if (Input.GetKey(KeyCode.None))
        {
            attackleft = false;
        }

    }

    }

