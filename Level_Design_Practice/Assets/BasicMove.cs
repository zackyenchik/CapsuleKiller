using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour {

    public float speed = 0.75f;
    public float jumpforce;
    public bool isgrounded = true;

	// Use this for initialization
	void Start () {
        jumpforce = 2f;
	}
	
	// Update is called once per frame
	void Update ()
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
        if (Input.GetKey(KeyCode.Space) && isgrounded)
        {
            transform.position += new Vector3(0, jumpforce, 0);
            speed = 0.35f;
            isgrounded = false;
        }
        if (position.y <= 1.1f)
        {
            speed = 0.75f;
            isgrounded = true;
        }
	}
}
