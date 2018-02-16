using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void LoadScene(string newGameLvl) // Used when the start button in the main menu is pressed
    {
        SceneManager.LoadScene(newGameLvl);
    }

    public void ExitButton() // Used when the exit buton in the main menu is pressed
    {
        Application.Quit();
    }
}