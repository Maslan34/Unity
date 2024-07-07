using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{


    public GameObject player;
    public GameObject player2;
    public GameObject gate;
    public GameObject gate2;

    public bool isGateActivated { get; set; } = false;
    public bool isGate2Activated { get; set; } = false;


    void Start()
    {
        
    }

  
    void Update()
    {

    }

    private void FixedUpdate()
    {
            MovePlayer();
            MovePlayer2();
            
            
    }


    void MovePlayer()
    {
        if(isGateActivated)
        {
            player.GetComponent<Rigidbody>().AddForce(Vector3.left * 0.5f);
        }
        player.GetComponent<Rigidbody>().AddForce(Vector3.right * 0.5f);


    }
    void MovePlayer2()
    {
  
        if (isGate2Activated)
        {
           
            player2.GetComponent<Rigidbody>().AddForce(Vector3.right * 0.5f);
        }
     
        player2.GetComponent<Rigidbody>().AddForce(Vector3.left * 0.5f);


    }


    private void OnTriggerEnter(Collider other)
    {


        Renderer mshRenderer = other.gameObject.GetComponent<MeshRenderer>();
        mshRenderer.material.color = Color.red;
        

        if(other.gameObject == gate)
        {

            Transform gate2Pos = gate2.GetComponent<Transform>();

            float newXPos= gate2Pos.position.x - 5 ;

            player.GetComponent<Transform>().position = new Vector3(newXPos, gate2Pos.position.y, gate2Pos.position.z);

            // player.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

            isGateActivated = true;
            player.GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 0) * 6;
            
            //player.transform.Rotate(0f, 0f, 180f);
        }

        if (other.gameObject == gate2)
        {

            Transform gatePos = gate.GetComponent<Transform>();

            float newXPos = gatePos.position.x + 5;

            player2.GetComponent<Transform>().position = new Vector3(newXPos, gatePos.position.y, gatePos.position.z);

            // player.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

            isGate2Activated = true;
            player2.GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 0) * 6;

            //player.transform.Rotate(0f, 0f, 180f);
        }

    }

   





}
