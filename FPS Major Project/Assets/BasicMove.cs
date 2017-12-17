using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour {

    public float speed = 0.35f;
    public float jumpforce;
    private bool grounded;

	// Use this for initialization
	void Start () {
        jumpforce = 4f;
        grounded = true;
	}


    // Update is called once per frame
    void FixedUpdate ()
    {
        Vector3 position = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetButtonDown("Jump") && grounded)
        {
            transform.position += new Vector3(0, jumpforce, 0);
            speed = 0.2f;
            grounded = false;
        }
        if (position.y <= 1)
        {
            grounded = true;
            speed = 0.35f;
        }
    }
}
