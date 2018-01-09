using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {

    public Transform PauseCanvas;
    public Camera PlayerCam;
    public GameObject Gun;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause () // Used to pause and un-pause the game
    {
        if (PauseCanvas.gameObject.activeInHierarchy == false) // If the pause menu isn't active
        {
           PauseCanvas.gameObject.SetActive(true); // Activate the pause menu
           Time.timeScale = 0f; // Set the time scale to 0 to pause the game's time
           PlayerCam.GetComponent<MouseLook>().enabled = false; // Disable the player's mouse look capabilities
           Gun.GetComponent<GunBehavior>().enabled = false; // Disable the gun
           Cursor.lockState = CursorLockMode.None; // Unlock the cursor
           Cursor.visible = true; // Make the cursor visible
        }

        else
        {
           PauseCanvas.gameObject.SetActive(false); // Deactivate the pause menu
           PlayerCam.GetComponent<MouseLook>().enabled = true; // Enable the player's mouse look capabilities
           Gun.GetComponent<GunBehavior>().enabled = true; // Enable the gun
           Time.timeScale = 1f; // Set the game's time back to normal
           Cursor.visible = false; // Make the cursor invisible
           Cursor.lockState = CursorLockMode.Locked; // Lock the cursor to the middle of the screen
        }
    }

    public void Quit(string menu) // Used when the exit to menu button is pressed in the pause menu
    {
        SceneManager.LoadScene(menu);
        PauseCanvas.gameObject.SetActive(false);
        PlayerCam.GetComponent<MouseLook>().enabled = true;
        Gun.GetComponent<GunBehavior>().enabled = true;
        Time.timeScale = 1f;
    }
}