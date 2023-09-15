using UnityEngine;

public class AxeAttack : MonoBehaviour
{
    public bool isAttacking = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            isAttacking = true;
            GetComponent<Animator>().SetTrigger("Attack");
        }
    }

    // Called when the attack animation hits something.
    private void OnTriggerStay(Collider other)
    {
        if (isAttacking)
        {
            // Check if the collision object implements the IDamagable interface.
            IDamagable damagable = other.GetComponent<IDamagable>();
            if (damagable != null)
            {
                float damage = CalculateDamage(); // Calculate the damage to deal.
                damagable.Damage(damage); // Deal damage to the object.
            }
        }
    }

    private float CalculateDamage()
    {
        // You can calculate damage based on player stats or any other relevant factors.
        // For example, you can use the player's strength or weapon stats.
        // Replace this with your own logic.
        float baseDamage = 1f; // Replace with your base damage value.
        // Calculate the damage based on your game's mechanics.
        float finalDamage = baseDamage; // You can adjust this formula based on your game's mechanics.
        return finalDamage;
    }

    // Called when the attack animation begins.
    public void StartAttack()
    {
        isAttacking = true;
    }

    // Called when the attack animation ends.
    public void EndAttack()
    {
        
        isAttacking = false;
    }
}
