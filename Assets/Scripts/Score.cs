using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject ScoreObject;
    public GameObject BallObject;
    public Sprite One;
    public Sprite Two;
    public Sprite Three;
    public Sprite Four;
    public Sprite Five;
    public Sprite Six;
    public Sprite Seven;
    public Sprite Eight;
    public Sprite Nine;
    public Sprite Zero;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        ScoreObject.GetComponent<SpriteRenderer>().sprite = Zero;
        count = 0;
    }

// Update is called once per frame
void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    { 
        count++;
        switch(count)
        {
            case 1:
                ScoreObject.GetComponent<SpriteRenderer>().sprite = One;
                break;
            case 2:
                ScoreObject.GetComponent<SpriteRenderer>().sprite = Two;
                break;
            case 3:
                ScoreObject.GetComponent<SpriteRenderer>().sprite = Three;
                break;
            case 4:
                ScoreObject.GetComponent<SpriteRenderer>().sprite = Four;
                break;
            case 5:
                ScoreObject.GetComponent<SpriteRenderer>().sprite = Five;
                break;
            case 6:
                ScoreObject.GetComponent<SpriteRenderer>().sprite = Six;
                break;
            case 7:
                ScoreObject.GetComponent<SpriteRenderer>().sprite = Seven;
                break;
            case 8:
                ScoreObject.GetComponent<SpriteRenderer>().sprite = Eight;
                break;
            case 9:
                ScoreObject.GetComponent<SpriteRenderer>().sprite = Nine;
                break;
            default:
                Application.Quit();
                break;
        }

        BallObject.GetComponent<Ball>().ResetBall();
        BallObject.GetComponent<Ball>().GoBall();
    }
}
