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
        /// yapabilirz ancak bu script zaten topa atandýðý için onun game objesi zaten bu nesneyi
        /// gösteriyor.
        /// Þununla ayný ->  rb2 = GameObject.GetComponent<Rigidbody2D>();
        rb2 = GetComponent<Rigidbody2D>();

        rb2.velocity = new Vector2(1, 0)* moveSpeed; // x ekseninde saða duru ilk hýz verildi.


    }

   

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        TagManager tagManager = collision.gameObject.GetComponent<TagManager>();

        GetComponent<AudioSource>().Play();
        if (tagManager == null) // sað ve sol duvar hariç bir yere top deðdi.
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


        //BURADA COLLIDIRI Y UZUNLUÐU ALINDI.
        float racketHeight = collision.gameObject.GetComponent<Collider2D>().bounds.size.y;

        float vector = result / racketHeight;

        rb2.velocity = new Vector2(x, vector) * moveSpeed;
    }

}
