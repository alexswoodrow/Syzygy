using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedFireatPlayer : MonoBehaviour
{
   public GameObject bullet;
    public float speed;
    public Vector2 playerpos;
    public bool isStoped;
    float start = 1f;
    public float shots = 2f;
    // Start is called before the first frame update
    void Start()
    {
        isStoped = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject move = GameObject.Find("boss1");
       // isStoped = move.GetComponent<bossMove>().stoped;
        if (start == 1)
        {
            Invoke("startlaunch", 0);
            start--;

        }
        GameObject player = GameObject.Find("player");
        playerpos = player.GetComponent<Transform>().position;
    }
    void launch1()
    {
        if (shots >= 0) {
            Vector2 target = new Vector2(playerpos.x, playerpos.y);
            Vector2 pos = new Vector2(transform.position.x - .1f, transform.position.y);
            Vector2 direction = target - pos;
            direction.Normalize();
            GameObject Projectile = (GameObject)Instantiate(bullet, pos, Quaternion.identity);
            Projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
            Invoke("startlaunch", 0);
        }
    }

    void startlaunch()
    {
        Invoke("launch1", 2);
        shots--;
    }
    }