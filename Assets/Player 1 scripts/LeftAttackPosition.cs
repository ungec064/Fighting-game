using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAttackPosition : MonoBehaviour
{
    public Transform LeftAttack;
    public Transform Player_1;
  

    void Start()
    {

        LeftAttack.position = Player_1.position;
        LeftAttack.parent = Player_1;
       
       
    }

    // Update is called once per frame
    void Update()
    {

        LeftAttack.position= Player_1.position;
        LeftAttack.parent = Player_1;

        
    }
}

