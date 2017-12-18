using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    public float sensitivity = 4f;
    float xRotation;
    float yRotation;
    public Camera cam;


	// Use this for initialization
	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor to the middle of the screen
	}
	
	// Update is called once per frame
	void Update () {
        xRotation += Input.GetAxis("Mouse Y") * sensitivity; // Get mouse movement for the x-rotation and scale by sensitivity
        yRotation += Input.GetAxis("Mouse X") * sensitivity; // Get mouse movement for the y-rotation and scale by sensitivity
        transform.localEulerAngles = new Vector3(0, yRotation, 0); // Rotate the player around the y-axis
        cam.transform.localEulerAngles = new Vector3(-xRotation, yRotation, 0); // Rotate the camera around the x and y axes
        xRotation = Mathf.Clamp(xRotation, -60, 60); // Lock the camera between -60 and 60 degrees on the y-axis
    }
}
