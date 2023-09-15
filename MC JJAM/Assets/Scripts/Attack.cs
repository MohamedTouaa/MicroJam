using UnityEngine;

public class AxeAttack : MonoBehaviour
{
    public int damage = 1; // Amount of damage to deal to enemies.

    private bool isAttacking = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for a left mouse button click (or any other input you prefer).
        {
            // Trigger the attack animation.
            GetComponent<Animator>().SetTrigger("Attack");
        }
    }

    // Called when the attack animation hits something.
    private void OnTriggerEnter(Collider other)
    {
        if (isAttacking && other.CompareTag("Enemy")) // Check if the collision is with an enemy.
        {
            // Deal damage to the enemy (you might want to call a method on the enemy's script).
            other.GetComponent<EnemyHealth>().TakeDamage(damage);
        }
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
