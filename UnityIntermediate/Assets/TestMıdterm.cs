using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMıdterm : MonoBehaviour
{



    public GameObject ball, goalkeeper;
    float ballPos;

    private void Awake()
    {
        
      
    }

    void Start()
    {
        ballPos = Random.Range(-16, 32);
        float  x = ball.gameObject.GetComponent<Transform>().position.x;
       float y = ball.gameObject.GetComponent<Transform>().position.y;

        Vector3 v = new Vector3(x, y, ballPos);

        ball.gameObject.GetComponent<Transform>().position = v;
       

    }

    // Update is called once per frame
    void Update()
    {
        ball.gameObject.GetComponent<Rigidbody>().position += Vector3.right*0.004f;

        if (goalkeeper.gameObject.GetComponent<Transform>().position.z < ballPos)
        {
            goalkeeper.gameObject.GetComponent<Transform>().position += Vector3.forward*0.003f;
        }
        else {
            goalkeeper.gameObject.GetComponent<Transform>().position += -Vector3.forward*0.003f;
        }
    }
}
