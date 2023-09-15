using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solder : war_mob
{
    public override void Start()
    {
        base.Start();
        
    }
    public override void Attack()
    {
        base.Attack();
        if (theTarget != null)
            theTarget.GetComponent<war_mob>().TakeDmg(dmg);
        else
            agent.SetDestination(transform.forward * 2);
    }
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<war_mob>() && other.tag == "enemy")
        {
            CanAttack = true;
            theTarget = other.transform;
            agent.SetDestination(other.transform.position);
        }
    }
}
