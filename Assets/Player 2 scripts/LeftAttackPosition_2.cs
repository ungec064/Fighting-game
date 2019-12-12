using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAttackPosition_2 : MonoBehaviour
{
    public Transform LeftAt_2;
    public Transform Player_2;
    
    


    void Start()
    {

        LeftAt_2.position = Player_2.position;
        LeftAt_2.parent = Player_2;
        
    }

    // Update is called once per frame
    void Update()
    {
       


        LeftAt_2.position = Player_2.position;
        LeftAt_2.parent = Player_2;

       
    }
}
