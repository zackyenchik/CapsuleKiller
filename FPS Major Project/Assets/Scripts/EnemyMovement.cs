using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    Transform Player;
    public float movespeed = 5f;
    public float mindistance = 1f;
    

    // Use this for initialization
    void Awake () {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Player); // Look at the player
        if (Vector3.Distance(transform.position, Player.position) >= mindistance) // If the enemy is greater than the minimum distance away from the player
        {
            transform.position += transform.forward * movespeed * Time.deltaTime; // Move towards the player
        }
        else
        {
            transform.position += transform.forward * 0 * Time.deltaTime;
        }
    }
}
