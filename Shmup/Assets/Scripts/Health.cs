using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 0f;
    public int plusScore = 10;
    public EnemyDestroySound other;
    public GameObject explo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mew = transform.position;

        if (health <= 0f)
        {

            //  GameObject player = GameObject.Find("player(Clone)");
          //  GameObject exploPrefab = Instantiate(explo, mew, Quaternion.identity);
           
        }
        if (health <= 0f)
        {
          
         //  GameObject player = GameObject.Find("player(Clone)");
        
            Destroy(gameObject);
           other.boomSound();
            
            Score.score += plusScore;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
       
        
        if (other.gameObject.tag == "goodBullet")
        {
            health -= 10;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "betterbullet")
        {
            health -= 20;
            Destroy(other.gameObject);
        }

    }
}
