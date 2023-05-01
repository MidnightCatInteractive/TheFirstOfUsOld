using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene");
    }

    public void QuitGame()
    {
        // This doesn't work in editor, only when we build
        Application.Quit();
    }
}