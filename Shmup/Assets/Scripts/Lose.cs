using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
       
         if (other.gameObject.tag == "player" && gameObject.tag == "projectile")
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (other.gameObject.tag == "player" && gameObject.tag == "wall")
        {
            SceneManager.LoadScene("MainMenu");
        }



    }
}
