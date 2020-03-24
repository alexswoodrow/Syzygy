using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public static bool pause = false;
    public GameObject pausemenuUI;
    PlayCon controls;
    bool paused = false;
    public int forpause = 0;
    // Start is called before the first frame update
    void Awake()
    {
        controls = new PlayCon();
        pausemenuUI.SetActive(false);
        controls.PlayerControls.Pause.started += ctx => tf();

    }

    private void OnEnable()
    {
        controls.PlayerControls.Enable();
    }

    private void OnDisable()
    {
        controls.PlayerControls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (forpause == 2)
        {
            Resume();
            forpause = 0;
        }
        if (forpause == 1)
        {
            Pause();
            forpause = 3;
        }
    }
    public void Resume()
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
    public void tf()
    {
        if (forpause == 0)
        {
            forpause = 1;
        }
        if (forpause == 3)
        {
            forpause = 2;
        }
    }
}
    

