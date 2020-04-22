using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroySound : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip boom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void boomSound()
    {
        AudioSource.PlayClipAtPoint(boom, transform.position);
    }
}
