using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ball : MonoBehaviour
{

    Rigidbody2D rb2;
    public float moveSpeed;
    Racket leftRacket,rightRacket;

    private void Awake()
    {
        leftRacket = GameObject.Find("LEFTRACKET").GetComponent<Racket>();
        rightRacket = GameObject.Find("RIGHTRACKET").GetComponent<Racket>();
    }
    void Start()
    {

        /// BURADA GameObject ball = GameObject.Find("ball");
        /// yapabilirz ancak bu script zaten topa atand��� i�in onun game objesi zaten bu nesneyi
        /// g�steriyor.
        /// �ununla ayn� ->  rb2 = GameObject.GetComponent<Rigidbody2D>();
        rb2 = GetComponent<Rigidbody2D>();

        rb2.velocity = new Vector2(1, 0)* moveSpeed; // x ekseninde sa�a duru ilk h�z verildi.


    }

   

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        TagManager tagManager = collision.gameObject.GetComponent<TagManager>();

        GetComponent<AudioSource>().Play();
        if (tagManager == null) // sa� ve sol duvar hari� bir yere top de�di.
            return;


        TagController tag = tagManager.wallTag; 

         if (tag == TagController.LEFT_WALL)
        {
            rightRacket.makeScore();


        }
         
        else if(tag.Equals(TagController.RIGHT_WALL))
        {
            leftRacket.makeScore();

        }
        else if (tag.Equals(TagController.LEFT_RACKET))
        {
            returnVelocity(collision,1);

        }
        else if (tag.Equals(TagController.RIGHT_RACKET))
        {
            returnVelocity(collision, -1);

        }
        else
            Console.WriteLine("Error");
    }

    private void returnVelocity(Collision2D collision,float x)
    {
        float ballY = transform.position.y;
        float racketY = collision.gameObject.GetComponent<Transform>().position.y;

        float result = ballY - racketY;


        //BURADA COLLIDIRI Y UZUNLU�U ALINDI.
        float racketHeight = collision.gameObject.GetComponent<Collider2D>().bounds.size.y;

        float vector = result / racketHeight;

        rb2.velocity = new Vector2(x, vector) * moveSpeed;
    }

}
