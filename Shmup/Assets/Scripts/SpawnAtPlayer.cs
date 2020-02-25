using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAtPlayer : MonoBehaviour
{ 
 public GameObject enemy;
public float speed = 5f;
public float spawn = 2f;
public float uptime;
public float spawnNumber = 0f;
public float spawny1;
public float spawny2;
public float spawny3;
public float spawny4;
public float spawny5;
public float spawntime1;
public float spawntime2;
public float spawntime3;
public float spawntime4;
public float spawntime5;
public float spawny;



// Start is called before the first frame update
void Start()
{


    // Invoke("launcher", spawn);
    spawnNumber = 5f;
}

// Update is called once per frame
void Update()
{

    GameObject player = GameObject.Find("player1");
    if (spawnNumber == 5f)
    {

        if (!IsInvoking("launcher"))
        {
            spawn = spawntime1;
            spawny = spawny1;
            Invoke("launcher", spawn);
            spawnNumber--;
        }
    }

    if (spawnNumber == 4f)
    {
        if (!IsInvoking("launcher"))
        {
            spawn = spawntime2;
            spawny = spawny2;
            Invoke("launcher", spawn);
            spawnNumber--;
        }

    }
    if (spawnNumber == 3f)
    {
        if (!IsInvoking("launcher"))
        {
            spawn = spawntime3;
            spawny = spawny3;
            Invoke("launcher", spawn);
            spawnNumber--;
        }

    }
    if (spawnNumber == 2f)
    {
        if (!IsInvoking("launcher"))
        {
            spawn = spawntime4;
            spawny = spawny4;
            Invoke("launcher", spawn);
            spawnNumber--;
        }

    }
    if (spawnNumber == 1f)
    {
        if (!IsInvoking("launcher"))
        {
            spawn = spawntime5;
            spawny = spawny5;
            Invoke("launcher", spawn);
            spawnNumber--;
        }

    }

}
void launcher()
{
    GameObject player = GameObject.Find("player");
    Vector3 playerpos = player.GetComponent<Transform>().position;
    Vector2 target = new Vector2(playerpos.x, playerpos.y);
    Vector2 pos = new Vector2(transform.position.x, spawny);
    Vector2 direction = target - pos;
    direction.Normalize();
    GameObject Projectile = (GameObject)Instantiate(enemy, pos, Quaternion.identity);
    Projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;

    }
}

