using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newspawnplayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 spawnsppot = new Vector3 (-8,0,0);
    
    private void Awake()
    {
        Instantiate(player, spawnsppot, Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
