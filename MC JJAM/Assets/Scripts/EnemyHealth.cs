using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : MonoBehaviour, IDamagable
{
    [SerializeField] private float maxHealth = 1f;

    public float currentHealth;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Damage(float damageAmount)
    {
        print("take dmg");
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {

            Die();

        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
