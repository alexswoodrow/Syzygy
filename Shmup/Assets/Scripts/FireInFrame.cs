using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInFrame : MonoBehaviour
{
    public GameObject bullet;
    public float speed;
    public Vector2 playerpos;
    float start = 1f;
    public float shots = 2f;
    public AudioClip badshoot;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 tracker = transform.position;
        if (tracker.x <= 8 && tracker.x >= -1)
        {
            if (start == 1f)
            {
                Invoke("launch1", 1.2f);
                start--;
            }

        }
        GameObject player = GameObject.Find("player(Clone)");
        playerpos = player.GetComponent<Transform>().position;
    }
    void launch1()
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (shots >= 0)
        {
            Vector2 target = new Vector2(playerpos.x, playerpos.y);
            Vector2 pos = new Vector2(transform.position.x -.4f, transform.position.y + .3f);
            Vector2 direction = target - pos;
            direction.Normalize();
            GameObject Projectile = (GameObject)Instantiate(bullet, pos, Quaternion.identity);
            Projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
            AudioSource.PlayClipAtPoint(badshoot, transform.position);            
            start++;
        }
    }
}
