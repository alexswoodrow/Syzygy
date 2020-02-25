using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller: MonoBehaviour
{
    Rigidbody2D rb;
    public float xspeed = 0f;
    public float yspeed = 0f;
    protected Vector2 velocity;
    Vector2 move = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = move;
        
    }

    // Update is called once per frame
    void Update()
    {

        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        move.x = xspeed;
        move.y = yspeed;

        if (Input.GetKey(KeyCode.D))
        {
            xspeed = 7f;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            xspeed = -7f;
        }
        else
        {
            xspeed = 0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            yspeed = 7f;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            yspeed = -7f;
        }
        else
        {
            yspeed = 0f;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(move.x, move.y);
    }
}
