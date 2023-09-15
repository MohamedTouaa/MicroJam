using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solder : war_mob
{
    public Transform camp_Enemy;
    public override void Start()
    {
        base.Start();
        if(transform.tag != "Enemy")
            camp_Enemy = GameObject.Find("camp enemy").transform;
        
    }
    public override void Update()
    {
        base.Update();
        if (theTarget == null)
            agent.SetDestination(camp_Enemy.position);
    }
    public override void Attack()
    {
        base.Attack();
        if (theTarget != null)
            theTarget.GetComponent<war_mob>().TakeDmg(dmg);
     ;
    }
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if ( other.tag == "Enemy")
        {
            print("aaaaaaaaaa");
            CanAttack = true;
            theTarget = other.transform;
            agent.SetDestination(other.transform.position);
        }
    }
}
