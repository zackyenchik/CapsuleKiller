using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    public float sensitivity = 4f;
    public float xRotation;
    public float yRotation;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        xRotation -= Input.GetAxis("Mouse Y") * sensitivity;
        yRotation += Input.GetAxis("Mouse X") * sensitivity;
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        xRotation = Mathf.Clamp(xRotation, -90, 90);
	}
}
