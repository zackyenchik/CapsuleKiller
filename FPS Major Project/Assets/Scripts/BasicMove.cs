using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{

    public float speed = 0.35f;
    private Rigidbody rb;
    Vector3 MoveDirection;
    public float jumpVel;
    public float maxSlope;
    private bool grounded;
    private Collision collision;
    private ContactPoint contact;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); // The rigidbody of the component the script is attached to (Player)
    }

    private void OnCollisionStay(Collision collision)
    {
        foreach(ContactPoint contact in collision.contacts) // For each collision
        {
            if (Vector3.Angle(contact.normal, Vector3.up) < maxSlope) // If the angle of the collision on the y-axis is less than the max slope
            {
                grounded = true; // Player is on the ground
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }

    void MovePlayer()
    {
        Vector3 yVelocity = new Vector3(0, rb.velocity.y, 0); // Store the y-velocity because MoveDirection always has a y-velocity of 0
        rb.velocity = MoveDirection * speed * Time.deltaTime; // Move the Player in the direction given by the user at the desired speed
        rb.velocity += yVelocity; // Add the y-velocity to the rigidbody'
        if (Input.GetButtonDown("Jump") && grounded) // If the space bar is pressed and the Player is on the ground
        {
            rb.AddRelativeForce(0, jumpVel, 0); // Add a relative force of the jump velocity on the y-axis
        }
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

