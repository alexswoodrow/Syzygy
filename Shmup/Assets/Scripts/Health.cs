using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject player = GameObject.Find("player");
        if (other.gameObject.tag == "goodBullet")
        {
            health -= 10;
            Destroy(other.gameObject);
        }


    }
}
