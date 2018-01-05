using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public float health;

    public void DamageEnemy(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            DestroyEnemy();
        }
    }

    void DestroyEnemy()
    {
        Destroy(gameObject); // Destroy the enemy
        ScoreSystem.score += 1; // Update the score
    }

}
