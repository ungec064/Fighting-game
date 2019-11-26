using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_2 : MonoBehaviour
{
    Attacks At;
    Movement2 Mv2;
    public float TakeDamage = 0;
    public float Hit = 0;
    public GameObject LeftAttack;
    public GameObject Player_1;
    private void OnTriggerEnter(Collider LeftAttack)
    {
        Hit = 1;
    }
    private void OnTriggerExit(Collider LeftAttack)
    {
        Hit = 0;
        TakeDamage = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        At = Player_1.GetComponent<Attacks>();
        GetComponent<Movement2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Hit == 1)
        {
            if (At.attackleft == true) {
                TakeDamage = 1;
            }
            if (At.attackleft == false)
            {
                TakeDamage = 0;
            }
        }
    }
}
