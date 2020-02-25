using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrClean : MonoBehaviour
{
    float thepos = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mypos = transform.position;
        mypos.y = 0;
        transform.position = mypos;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            Destroy(other.gameObject);
        }
    }

}
