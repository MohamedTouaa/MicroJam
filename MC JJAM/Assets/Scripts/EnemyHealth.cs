using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : MonoBehaviour, IDamagable
{
    [SerializeField] private float maxHealth = 1f;

    public float currentHealth;
    audioManagers mm;


    // Start is called before the first frame update
    void Start()
    {
        GameObject a = GameObject.Find("Player");
        mm = a.transform.GetChild(3).GetComponent<audioManagers>();
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
            if (transform.tag == "cow") mm.playS("cow_die");
            if (transform.tag == "sheep") mm.playS("sheep_die");
            if (transform.tag == "humain") mm.playS("humain_die");

            Die();

        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
