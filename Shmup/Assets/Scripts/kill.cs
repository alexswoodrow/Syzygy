using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    public GameObject playership;
    Vector3 startingpos = new Vector3(-3, 0, 0);
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
        GameObject player = GameObject.Find("player");
       
        
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Instantiate(playership,startingpos,Quaternion.identity);
            lives.lifenum--;
        }
    }
    
}
