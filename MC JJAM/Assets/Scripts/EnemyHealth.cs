using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 1;  // Maximum health of the enemy.
    private int currentHealth;   // Current health of the enemy.

    private void Start()
    {
        currentHealth = maxHealth; // Initialize current health to maximum health.
    }

    // Method to apply damage to the enemy.
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Reduce current health by the amount of damage taken.

        // Check if the enemy's health has dropped to or below zero.
        if (currentHealth <= 0)
        {
            Die(); // Call a method to handle enemy death (e.g., play death animation and remove the enemy).
        }
    }

    // Method to handle the enemy's death.
    private void Die()
    {
        // Perform any death-related actions here, such as playing death animations, dropping loot, or removing the enemy from the scene.
        Destroy(gameObject); // For simplicity, we'll just destroy the enemy GameObject when it dies.
    }
}
