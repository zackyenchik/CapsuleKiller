using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehavior : MonoBehaviour {

    public float damage;
    public Camera cam;
    public ParticleSystem muzzleFlash;
    public AudioSource shot;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) // If the left mouse button is clicked
        {
            ShootGun(); // Shoot the gun
        }
	}

    void ShootGun()
    {
        muzzleFlash.Play(); // Play the muzzle flash ParticleSystem
        shot.Play(); // Play the gunshot audio clip
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit)) // If the raycast hits something
        {
            Target target = hit.transform.GetComponent<Target>(); // Store the Target component of the raycast hit as a Target variable
            if (target != null) // If the object the raycast hits has a Target component
            {
                target.DamageEnemy(damage); // Do the specified amount of damage to the object
            }
        }
    }
}
