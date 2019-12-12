using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_1 : MonoBehaviour
{
    Attack_2 At;
    Movement2 Mv;
    public float TakeDamage_2 = 0;
    public float Hit_2 = 0;
    public GameObject LeftAttack_2;
    public GameObject Player_2;
    

    private void OnTriggerEnter(Collider LeftAttack_2)
    {
        Hit_2 = 1;
    }
    private void OnTriggerExit(Collider LeftAttack_2)
    {
        Hit_2 = 0;
        TakeDamage_2 = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        

        At = Player_2.GetComponent<Attack_2>();
        GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Hit_2 == 1)
        {
            
            if (At.attackleft_2 == true)
            {
                TakeDamage_2 = 1;
               
            }
            if (At.attackleft_2 == false)
            {
                TakeDamage_2 = 0;
               
            }
        }
    }
}