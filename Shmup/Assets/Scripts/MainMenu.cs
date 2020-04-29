using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string playGameLevel;

    public string LevelSelecter;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
        lives.lifenum = 3;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LevelSelect ()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void ControlScreen() {
        SceneManager.LoadScene("Instructions");
    }

}

