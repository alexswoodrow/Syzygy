using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUp : MonoBehaviour
{
    float thepos = 0f;
    public float ypos = 0f;
    


    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mypos = transform.position;
        GameObject player = GameObject.Find("player");
        thepos = player.GetComponent<Transform>().position.x;
        mypos.x = thepos - 24f;
        mypos.y = ypos;
        transform.position = mypos; //charger games helped me figure out how to fix my position with his youtube tutorials
       

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "astroid") {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
