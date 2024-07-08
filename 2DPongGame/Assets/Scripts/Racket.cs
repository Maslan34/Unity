
using System;
using TMPro;
using UnityEngine;

public abstract class Racket : MonoBehaviour
{


    public float moveSpeed = 5;
    public TMP_Text scoreText;
   

    GameObject leftRacket;
    GameObject rightRacket;


    public int Score { get;private set; } = 0;

    private void Awake()
    {
         leftRacket = GameObject.Find("LEFTRACKET");
         rightRacket = GameObject.Find("RIGHTRACKET");
        
    }
    void Start()
    {
        
    }

    // RigidBodyle ilgili iþlemler olduðu için fixed kullanýldý.
    private void FixedUpdate()
    {
        Move();
    }

    protected abstract void Move();
    public void makeScore()
    {
       Score++;
        scoreText.text = Score.ToString();
    }

   
}
