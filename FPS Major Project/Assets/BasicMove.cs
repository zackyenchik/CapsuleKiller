using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{

    public float speed = 0.35f;
    public float jumpforce;
    private bool grounded;
    private Rigidbody rb;
    Vector3 MoveDirection;

    // Use this for initialization
    void Start()
    {
        jumpforce = 4f;
        grounded = true;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void MovePlayer()
    {
        Vector3 yVelocity = new Vector3(0, rb.velocity.y, 0);
        rb.velocity = rb.velocity = MoveDirection * speed * Time.deltaTime;
        rb.velocity += yVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");
        MoveDirection = (horizontalMovement * transform.right + verticalMovement * transform.forward).normalized;

    }

}

