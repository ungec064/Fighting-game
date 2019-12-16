using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAttackPosition_2 : MonoBehaviour
{
    public Transform LeftAt_2;
    public Transform Player_2;
    public ParticleSystem LAttackEf;
    public Attack_2 At;


    void Start()
    {

        LeftAt_2.position = Player_2.position;
        LeftAt_2.parent = Player_2;
        LAttackEf = GetComponent<ParticleSystem>();
        LAttackEf.Play(false);
    }

    // Update is called once per frame
    void Update()
    {
        LAttackEf.Play(false);


        LeftAt_2.position = Player_2.position;
        LeftAt_2.parent = Player_2;

        if (At.PlayPartical == 1)
        {
            LAttackEf.Play(true);
        }
        if (At.PlayPartical == 0)
        {
            LAttackEf.Stop(true);

        }
    }
}
