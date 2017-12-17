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
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        xRotation += Input.GetAxis("Mouse Y") * sensitivity;
        yRotation += Input.GetAxis("Mouse X") * sensitivity;
        transform.localEulerAngles = new Vector3(0, yRotation, 0);
        cam.transform.localEulerAngles = new Vector3(-xRotation, yRotation, 0);
        xRotation = Mathf.Clamp(xRotation, -60, 60);
    }
}
