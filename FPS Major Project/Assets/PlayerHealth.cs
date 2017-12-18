using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public Transform Enemy;
    public float currentHealth;
    public float startHealth = 100;
    public float mindistance = 1f;
    public float attackcooldown = 10f;

	// Use this for initialization
	void Start () {
        currentHealth = startHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(transform.position, Enemy.position) <= mindistance && attackcooldown == 0f)
        {
            currentHealth -= 1;
            attackcooldown += 10f;
        }
        if (attackcooldown > 0)
        {
            attackcooldown -= 1;
        }
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
