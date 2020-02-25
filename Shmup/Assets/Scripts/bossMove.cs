using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossMove : MonoBehaviour
{
    float mypos = 0f;
    public bool stoped = false;
    // Start is called before the first frame update
    void Start()
    {
        mypos = transform.position.x;
        stoped = false;
    }

    // Update is called once per frame
    void Update()
    {
        mypos = transform.position.x;
        if (mypos >=8f)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0);
            stoped = false;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            stoped = true;
        }
    }
}
