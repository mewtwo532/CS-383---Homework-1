using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D body;
    public int Speed = 1;

    public void GoBall()
    {
        float rand = Random.Range(0, 4);
        if (rand < 1)
        {
            body.AddForce(new Vector2(Speed * 20, Speed * -15));
        }
        else if (rand < 2)
        {
            body.AddForce(new Vector2(Speed * -20, Speed * 15));
        }
        else if (rand < 3)
        {
            body.AddForce(new Vector2(Speed * 20, Speed * 15));
        }
        else
        {
            body.AddForce(new Vector2(Speed * -20, Speed * -15));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetBall()
    {
        body.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = -body.velocity.x;
            vel.y = body.velocity.y;
            body.velocity = vel;
            
        }
    }

    public void GoBallButton()
    {
        ResetBall();
        System.Threading.Thread.Sleep(5000);
        GoBall();
    }

}
