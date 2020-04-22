using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller: MonoBehaviour
{
    Rigidbody2D rb;
    public float xspeed = 7f;
    public float yspeed = 7f;
    protected Vector2 velocity;
    Vector2 move = Vector2.zero;
   
    // Start is called before the first frame update
    PlayCon inputActions;

    Vector2 moveinput;

    Vector2 joymove;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = move;
        inputActions = new PlayCon();
       // inputActions.PlayerControls.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            xspeed = 10f;
            yspeed = 10f;
        }
        else
        {
            xspeed = 7f;
            yspeed = 7f;
        }
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        

        if (Input.GetKey(KeyCode.D))
        {
            move.x = xspeed;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            move.x = xspeed * -1;
        }
        else
        {
            move.x = 0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
           move.y = yspeed;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            move.y= yspeed * -1;
        }
        else
        {
           move.y = 0f;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(move.x, move.y);
    }
}
