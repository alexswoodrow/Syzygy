using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public int plusScore = 10;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D (Collision2D other) 
    {
        {
            if (other.gameObject.tag == "astroid")
            {
                GameObject player = GameObject.Find("player");
                Score.score += plusScore;

                Destroy(other.gameObject);
                Destroy(gameObject);
            }

            if (other.gameObject.tag == "bullet")
            {
                Destroy(gameObject);

            }
        }
    }
}
