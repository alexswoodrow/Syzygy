using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public GameObject bullet;
    public float speed = 5.0f;
    public float thespawn = 2f;
    public float bulletspawn = 1f;
    bool IsShoot = false;

    PlayCon controls;
    public AudioClip shootSound;

    // Use this for initialization
    void Awake()
    {
        controls = new PlayCon();

        controls.Shoot.Shoot.performed += ctx => Bang();
        controls.Shoot.Shoot.canceled += ctx => Click();
    }

        // Update is called once per frame
        void Update () {
        if (IsShoot == true && bulletspawn == 1f)
        {
          
            Invoke("launchOrb", thespawn);
            if (!IsInvoking("launchOrb"))
            {  //big thank to Unity for the !Invoking do it again script (it was just on the webiste to explain isinvoking)
                Invoke("launchOrb", thespawn);
              
            }
            bulletspawn--;
        }
       

    }
    void launchOrb ()
    {
        AudioSource audio = GetComponent<AudioSource>();
        
        Vector2 target = new Vector2(10,transform.position.y);
        Vector2 pos = new Vector2(transform.position.x + 1f, transform.position.y);
        Vector2 direction = target - pos;
        direction.Normalize();
        GameObject Projectile = (GameObject)Instantiate(bullet, pos, Quaternion.identity);
        Projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
        bulletspawn++;
        AudioSource.PlayClipAtPoint(shootSound, transform.position);
    }
    private void OnEnable()
    {
        controls.Shoot.Enable();
    }

    private void OnDisable()
    {
        controls.Shoot.Disable();
    }
    void Bang()
    {
        IsShoot = true;
        Debug.Log("bang");
    }
    void Click()
    {
        IsShoot = false;
    }

}
