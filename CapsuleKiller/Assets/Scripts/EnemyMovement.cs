using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    Transform Player;
    public float movespeed = 6f;

    // Use this for initialization
    void Awake () {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        float move = movespeed * Time.deltaTime;
        transform.LookAt(Player); // Look at the player
        transform.position = Vector3.MoveTowards(transform.position, Player.position, move); // Move towards the player
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            movespeed = 0; // Stop the enemy from moving if they collide with the player
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        movespeed = 6f; // Allow the enemy to move again when they stop colliding with the player
    }
}
