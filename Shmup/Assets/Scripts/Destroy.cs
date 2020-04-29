using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public int plusScore = 10;
    public GameObject explo;
    //private ParticleSystem particles;

    // Start is called before the first frame update
    void Start() {
        //particles = exploTransform.GetComponent<ParticleSystem>();
        //particles.Stop();
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

                GameObject exploPrefab = Instantiate(explo, other.gameObject.transform);
                Destroy(other.gameObject);
                Destroy(gameObject);
            }

            if (other.gameObject.tag == "bullet")
            {
                Destroy(gameObject);

            }
            if (gameObject.tag == "betterbullet" && other.gameObject.tag == "bullet")
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
            else if (other.gameObject.tag != "bullet" || other.gameObject.tag != "betterbullet" || other.gameObject.tag != "friend") {
                GameObject exploPrefab = Instantiate(explo, other.gameObject.transform);
            }
        }
    }


}
