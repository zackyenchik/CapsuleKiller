using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {

    Text ScoreText;
    public static int score;

    private void Awake()
    {
        ScoreText = GetComponent<Text>(); // Create reference to the UI text component                                                           
        score = 0; // Set the score to 0
    }

    // Update is called once per frame
    void Update () {
        ScoreText.text = "Score: " + score; // Display the score
	}
}
