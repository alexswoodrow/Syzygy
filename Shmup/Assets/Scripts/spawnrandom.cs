using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnrandom: MonoBehaviour
{
    public GameObject projectile;
    public float speed = 5f;
    public float min = 0.5f;
    public float spawn;
    float theTarx;
    float theTary;
    public float thex1 = 0f;
    public float thex2 = 0f;
    public float they1 = 0f;
    public float they2 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spawn = Random.Range(min, 2f);
        Invoke("launcher", spawn);
        theTarx = Random.Range(0f,-10f);
        theTary = Random.Range(0f, 3f);

    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("player2");
       

        if (!IsInvoking("launcher")) {  //big thank to Unity for the !Invoking do it again script (it was just on the webiste to explain isinvoking)
            spawn = Random.Range(min, 2f);
            theTarx = Random.Range(thex1 , thex2 );
            theTary = Random.Range(they1, they2);
            Invoke("launcher", spawn);
        }


    }
    void launcher()
    {

        Vector2 target = new Vector2(theTarx, theTary);
        Vector2 pos = new Vector2(transform.position.x, transform.position.y);
        Vector2 direction = target - pos;
        direction.Normalize();
        GameObject Projectile = (GameObject)Instantiate(projectile, pos, Quaternion.identity);
        Projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
