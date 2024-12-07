using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth; // Initialize health
    }

    // Function to decrease health when damage is taken
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Function for death (destroy object)
    private void Die()
    {
        Debug.Log(gameObject.name + " has died!");
        Destroy(gameObject);  // Destroy the player or enemy object
    }

    // Function to heal the player
    public void Heal(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth); // Ensure health doesn't go beyond max
    }
}
