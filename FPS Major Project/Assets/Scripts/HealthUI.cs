using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour {

    Text HealthText;
    public static int health;

    private void Awake()
    {
        HealthText = GetComponent<Text>(); // Create a reference to the UI text component
        health = 100; // Set the health to 100
    }

    // Update is called once per frame
    void Update () {
        HealthText.text = "Health: " + health; // Display the health
	}
}
