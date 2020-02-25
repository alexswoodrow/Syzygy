using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public static bool pause = false;
    public GameObject pausemenuUI;

    // Start is called before the first frame update
    void Start()
    {
        pausemenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause == true)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }
    public void Resume ()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }
    void Pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("are you sure?");
    }
   public void menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

}

