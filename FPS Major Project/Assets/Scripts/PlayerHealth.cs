using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public int currentHealth;
    public int startHealth = 100;
    public float attackcooldown = 10f;

	// Use this for initialization
	void Start () {
        currentHealth = startHealth; // Initialize the health to 100
	}
	
	// Update is called once per frame
	void Update () {
        if (attackcooldown > 0)
        {
            attackcooldown -= 1; // Decrease the attack cooldown
        }
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver"); // Load game over scene if the player's health reaches 0
            Cursor.lockState = CursorLockMode.None; // Unlock the cursor
            Cursor.visible = true; // Make the cursor visible
        }
	}

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy") // If the player is colliding with an enemy
        {
            if (attackcooldown <= 0f)
            {
                currentHealth -= 1; // Subtract 1 from the player's health
                HealthUI.health -= 1; // Update the UI's health texxt
                attackcooldown = 10; // Set the attack cooldown to 10
            }
        }
    }
}
