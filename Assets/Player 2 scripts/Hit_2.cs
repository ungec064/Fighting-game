using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_2 : MonoBehaviour
{
    Attacks At;
    Movement2 Mv2;
    public float Hit = 0;
    public GameObject LeftAttack;
    private void OnTriggerEnter(Collider LeftAttack)
    {
        Hit = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Hit == 1)
        {
            if (At.attackleft == true) {
                Mv2.Health = Mv2.Health - 5;
            }
        }
    }
}
