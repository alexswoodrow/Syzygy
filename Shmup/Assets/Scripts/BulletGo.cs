using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer therenderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        Vector3 friendly = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, friendly, 1)){
            Debug.Log("yes");
        }
        Vector3 friendlys = transform.TransformDirection(Vector3.back);
        if (Physics.Raycast(transform.position, friendlys, 1))
        {
            Debug.Log("yes");
        }
    }
    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
        if (gameObject.transform.tag == "betterbullet")
        {
            SpriteRenderer therenderer = GetComponent<SpriteRenderer>();
            therenderer.color = new Color(0, 0, 1, 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player" && other.gameObject.tag != "friend")
        {
            Destroy(gameObject);
            Debug.Log("hit");

        }
        if (other.gameObject.tag == "friend")
        {
            gameObject.tag = "betterbullet";
            Debug.Log("finally");
        }
    }
}
  

