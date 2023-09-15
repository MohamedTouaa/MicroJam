using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : war_mob
{
    [SerializeField] GameObject bullet;
   
    public override void Attack()
    {
        base.Attack();
        GameObject bul = Instantiate(bullet, transform.position, Quaternion.identity);
        Rigidbody bulRb = bul.AddComponent<Rigidbody>();
        bulRb.useGravity = false;
        bul.name = "bullet";
        bulRb.constraints = RigidbodyConstraints.FreezeRotation;
        bulRb.AddForce(transform.forward * 20f, ForceMode.Impulse);
        Destroy(bul, 3.2f);
    }
    private void OnTriggerStay(Collider other)
    {
        if ( other.tag == "Enemy")
        {
            print("archer in enemy");
            // enemyList.Add(other.GetComponent<Enemy>());
            CanAttack = true;
            theTarget = other.transform;
        }
    }
}
