using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selector : MonoBehaviour
{
    public string Level1;

    public string Level2;
    public string Level3;
    public string Level4;
    public string Level5;
    public string Level6;

    public string Menu;

    public void FirstLevel()
    {
        SceneManager.LoadScene(Level1);
    }

    public void MainMenu()
    {
        Application.LoadLevel(Menu);
    }

    public void SecondLevel()
    {
        SceneManager.LoadScene(Level2); ;
    }
    public void ThirdLevel()
    {
        SceneManager.LoadScene(Level3);
    }
    public void ForthLevel()
    {
        SceneManager.LoadScene(Level4);
    }
    public void FifthLevel()
    {
        SceneManager.LoadScene(Level5);
    }
    public void SixthLevel()
    {
        SceneManager.LoadScene(Level6);
    }
}
