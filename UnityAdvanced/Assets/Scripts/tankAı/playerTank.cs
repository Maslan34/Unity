using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTank : Tank
{
    float moveSpeed=10f;
    float rotaionSpeed = 240f;


    protected override void Move()
    {
        float moveAxis = Input.GetAxis("Vertical");
        float rotationAxis = Input.GetAxis("Horizontal");
        
        rb.MovePosition(transform.position+transform.forward* moveSpeed*Time.deltaTime*moveAxis);
        rb.MoveRotation(transform.rotation * Quaternion.Euler(transform.up * rotationAxis *rotaionSpeed * Time.deltaTime)); // Y Ekseninde dönme
        
        createMoveAffect(moveAxis);
    
    
        if(Input.GetKeyDown(KeyCode.Space)) {
            StartCoroutine(lookAndShot(other));
        }
    
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
