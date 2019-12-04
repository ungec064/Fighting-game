using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAttackPosition : MonoBehaviour
{
    public Transform LeftAt;
    public Transform Player_1;
    public Attacks At;
    public ParticleSystem LAttackEf;


    void Start()
    {
       
        LeftAt.position = Player_1.position;
        LeftAt.parent = Player_1;
        LAttackEf = GetComponent<ParticleSystem>();
        LAttackEf.Play(false);
    }

    // Update is called once per frame
    void Update()
    {
        LAttackEf.Play(false);


        LeftAt.position= Player_1.position;
        LeftAt.parent = Player_1;
        
        if(At.PlayPartical == true)
        {
            LAttackEf.Play(true);
        }
        if (At.PlayPartical == false)
        {
            LAttackEf.Stop(true);
            LAttackEf.Play(false);
        }
    }
}

