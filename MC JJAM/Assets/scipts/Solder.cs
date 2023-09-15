using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solder : war_mob
{
    Transform camp_Enemy;
    public override void Start()
    {
        base.Start();
        camp_Enemy = GameObject.Find("camp enemy").transform;
        
    }
    public override void Attack()
    {
        base.Attack();
        if (theTarget != null)
            theTarget.GetComponent<war_mob>().TakeDmg(dmg);
        else
            theTarget = camp_Enemy;
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
