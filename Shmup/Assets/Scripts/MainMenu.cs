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
        Application.LoadLevel(playGameLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LevelSelect ()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void ControlScreen() {
        //Application.LoadLevel(); //Unity is telling me this is an "obselete way to load scene" ?
    }

}

