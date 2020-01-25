using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleKeyboard : MonoBehaviour
{
    public float Speed = 1.0f;
    public bool player1 = false;
    public bool player2 = false;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = body.velocity;
        if (Input.GetKey("escape"))
            Application.Quit();
        if (player1)
        {
            if (Input.GetKey("w"))
                velocity.y = Speed;
            else if (Input.GetKey("s"))
                velocity.y = -Speed;
            else
                velocity.y = 0;
        }
        if (player2)
        {
            if (Input.GetKey(KeyCode.UpArrow))
                velocity.y = Speed;
            else if (Input.GetKey(KeyCode.DownArrow))
                velocity.y = -Speed;
            else
                velocity.y = 0;
        }
        body.velocity = velocity;
    }
}
