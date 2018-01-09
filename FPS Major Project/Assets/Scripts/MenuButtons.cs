using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void StartButton(string newGameLvl)
    {
        SceneManager.LoadScene(newGameLvl);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}