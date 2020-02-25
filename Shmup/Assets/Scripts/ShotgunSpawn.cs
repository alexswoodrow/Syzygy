using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunSpawn : MonoBehaviour
{
    public GameObject bullet;
    public bool isStoped;
    public float speed;
    public float tarx1;
    public float tary1;
    public float tarx2;
    public float tary2;
    public float tarx3;
    public float tary3;
    public float tarx4;
    public float tary4;
    public float tarx5;
    public float tary5;
    float start = 1f;
    // Start is called before the first frame update
    void Start()
    {
        isStoped = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject move = GameObject.Find("boss1");
        isStoped = move.GetComponent<bossMove>().stoped;
        if (isStoped == true && start ==1)
        {
            Invoke("startlaunch", 0);
            start--;
            
        }
    }
    void launch1()
    {
        Vector2 target = new Vector2(tarx1, tary1);
        Vector2 pos = new Vector2(transform.position.x - 1f, transform.position.y+.4f);
        Vector2 direction = target - pos;
        direction.Normalize();
        GameObject Projectile = (GameObject)Instantiate(bullet, pos, Quaternion.identity);
        Projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
    void launch2()
    {
        Vector2 target = new Vector2(tarx2, tary2);
        Vector2 pos = new Vector2(transform.position.x - 1f, transform.position.y+.2f);
        Vector2 direction = target - pos;
        direction.Normalize();
        GameObject Projectile = (GameObject)Instantiate(bullet, pos, Quaternion.identity);
        Projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
    void launch3()
    {
        Vector2 target = new Vector2(tarx3, tary3);
        Vector2 pos = new Vector2(transform.position.x - 1f, transform.position.y);
        Vector2 direction = target - pos;
        direction.Normalize();
        GameObject Projectile = (GameObject)Instantiate(bullet, pos, Quaternion.identity);
        Projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
    void launch4()
    {
        Vector2 target = new Vector2(tarx4, tary4);
        Vector2 pos = new Vector2(transform.position.x - 1f, transform.position.y-.2f);
        Vector2 direction = target - pos;
        direction.Normalize();
        GameObject Projectile = (GameObject)Instantiate(bullet, pos, Quaternion.identity);
        Projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
    void launch5()
    {
        Vector2 target = new Vector2(tarx5, tary5);
        Vector2 pos = new Vector2(transform.position.x - 1f, transform.position.y-.4f);
        Vector2 direction = target - pos;
        direction.Normalize();
        GameObject Projectile = (GameObject)Instantiate(bullet, pos, Quaternion.identity);
        Projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
    void startlaunch()
    {
        InvokeRepeating("launch1", 3, 4);
        InvokeRepeating("launch2", 3, 4);
        InvokeRepeating("launch3", 3, 4);
        InvokeRepeating("launch4", 3, 4);
        InvokeRepeating("launch5", 3, 4);
    }
}
