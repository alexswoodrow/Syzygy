using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lives : MonoBehaviour
{
    public static int lifenum = 3;
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (lifenum == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("lose");
        }
    }
}
