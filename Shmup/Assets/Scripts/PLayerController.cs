using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PLayerController : MonoBehaviour
{

    PlayCon controls;

    Vector2 move;
    public float speed;
    bool boost = false;

    void Awake()
    {
        speed = 7f;
        controls = new PlayCon();

        controls.PlayerControls.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.PlayerControls.Move.canceled += ctx => move = Vector2.zero;
        controls.PlayerControls.Boost.performed += ctx => Booster();
        controls.PlayerControls.Boost.canceled += ctx => NoBooster();
    }
    // Start is called before the first frame update
    private void OnEnable()
    {
        controls.PlayerControls.Enable();
    }

    private void OnDisable()
    {
        controls.PlayerControls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (boost == true)
        {
            speed = 12f;
        } else
        {
            speed = 7f;
        }
        Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime * speed;
        transform.Translate(m, Space.World);
    }
    void Booster()
    {
        boost = true;
    }
    void NoBooster()
    {
        boost = false;
    }
}
