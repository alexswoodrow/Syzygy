using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public float speed = -1f;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
    }

}
