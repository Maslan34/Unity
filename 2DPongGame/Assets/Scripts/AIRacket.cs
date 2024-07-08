
using System;
using TMPro;
using UnityEngine;

public class AIRacket : Racket
{
    GameObject ball;

    private void Awake()
    {
        ball = GameObject.Find("BALL");
    }


    protected override void Move()
    {
            

        Transform ballPosition = ball.GetComponent<Transform>();
        //Debug.Log(ballPosition.position.y);

        // MESAFENIN MUTLAK DEGERI LAZIM CUNKU -X EKSENINI ONEMSEMIYORUZ
        float distance = MathF.Abs(transform.position.y - ballPosition.position.y);
        if (distance > 3) {
            if (transform.position.y < ballPosition.position.y)
            {
                Debug.Log("here");
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * moveSpeed;
            }
            else
            {
                Debug.Log("here2");
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * moveSpeed;
            }
        }
        
    }
}
