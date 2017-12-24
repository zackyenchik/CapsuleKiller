using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    public float sensitivity = 4f;
    public float smoothing = 2f;
    Vector2 mouseLook;
    Vector2 smoothVector;
    public GameObject Player;


	// Use this for initialization
	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor to the middle of the screen
	}
	
	// Update is called once per frame
	void Update () {
        var deltaMove = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")); // Get input for the mouse movement on the x and y axes
        deltaMove = Vector2.Scale(deltaMove, new Vector2(sensitivity * smoothing, sensitivity * smoothing)); // Multiply mouse input by the sensitivity and smoothing
        smoothVector.x = Mathf.Lerp(smoothVector.x, deltaMove.x, 1f / smoothing); // Use linear interpretation to move the camera smoothly on the x axis based on user input
        smoothVector.y = Mathf.Lerp(smoothVector.y, deltaMove.y, 1f / smoothing); // Use linear interpretation to move the camera smoothly on the y axis based on user input
        mouseLook += smoothVector; // Add the total movement to apply it to the Player and camera
        mouseLook.y = Mathf.Clamp(mouseLook.y, -60f, 60f); // Lock the mouse movement on the y axis between -60 and 60
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right); // Use the mouse movement on the y axis to rotate the camera up and down around the x axis
        Player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, Player.transform.up); // Use the mouse movement on the x axis to rotate the Player around the y axis
    }
}
