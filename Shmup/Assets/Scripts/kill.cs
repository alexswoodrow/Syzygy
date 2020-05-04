using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    public GameObject playership;
    Vector3 startingpos = new Vector3(-7, 0, 0);
    public AudioClip diediedie;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject player = GameObject.Find("player(Clone)");
       
        
        if (other.gameObject.tag == "Player")
        {
            InvokeRepeating("chocolate", 1, 1);
            AudioSource.PlayClipAtPoint(diediedie, transform.position);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "betterBullet")
        {
            Destroy(gameObject);
        }
    }
    void chocolate ()
    {
        
        lives.lifenum--;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void banana ()
    {

    }
    
}
