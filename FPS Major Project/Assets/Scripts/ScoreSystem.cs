using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {

    Text text;
    public static int score;

	// Use this for initialization
	void Start () {	
	}

    private void Awake()
    {
        text = GetComponent<Text>(); // Create reference to the UI text component
        score = 0; // Set the score to 0
    }

    // Update is called once per frame
    void Update () {
        text.text = "Score: " + score; // Display the score
	}
}
