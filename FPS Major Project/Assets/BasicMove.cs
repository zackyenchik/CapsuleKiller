using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{

    public float speed = 0.35f;
    public float jumpforce;
    private Rigidbody rb;
    Vector3 MoveDirection;

    // Use this for initialization
    void Start()
    {
        jumpforce = 0.3f;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); // The rigidbody of the component the script is attached to (Player)
    }

    void MovePlayer()
    {
        Vector3 yVelocity = new Vector3(0, rb.velocity.y, 0); // Store the y-velocity because MoveDirection always has a y-velocity of 0
        rb.velocity = MoveDirection * speed * Time.deltaTime; // Move the Player in the direction given by the user at the desired speed
        rb.velocity += yVelocity; // Add the y-velocity to the rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        float horizontalMovement = Input.GetAxisRaw("Horizontal"); // Store user input for horizontal movement
        float verticalMovement = Input.GetAxisRaw("Vertical"); // Store user input for vertical movement
        MoveDirection = (horizontalMovement * transform.right + verticalMovement * transform.forward).normalized; // Combine horizontal and vertical movement into one vector and normalize to ensure the same speed when travelling diagonally
    }

}

