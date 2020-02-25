using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public float thepos = 0f;
    public float ypos;
    public bool thedead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (thedead == false)
        {
            Vector3 mypos = transform.position;
            GameObject player = GameObject.Find("boss1");
            thepos = player.GetComponent<Transform>().position.x;
            thedead = player.GetComponent<BossHealth>().dead;
            mypos.x = thepos + 10f;
            transform.position = mypos;
        }
        if (thedead == true) 
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0);
        }
    }
}
