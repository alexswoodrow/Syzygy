using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public string playGameLevel;

    public string LevelSelecter;

    public void PlayGame()
    {
        Application.LoadLevel(playGameLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LevelSelect ()
    {
        Application.LoadLevel(LevelSelecter);
    }
}

