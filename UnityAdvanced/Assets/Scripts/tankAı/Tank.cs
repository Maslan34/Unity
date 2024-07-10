using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tank : MonoBehaviour
{

    public Rigidbody rb { get { return GetComponent<Rigidbody>(); } }

    public Transform other;
    public Transform turret;
    public Rigidbody bombPrefab;
    public Transform bombspawn;
    [Range(15000f,30000f)]
    public float bombspeed=15000f;
    public Material mat;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    protected abstract void Move();

    protected IEnumerator lookAndShot(Transform other) // zaman aldýðý için IEnumerator kullanýldý.
    {

        while (Vector3.Angle(turret.forward, (other.position - transform.position)) > 5f)
        {
            turret.Rotate(turret.up * 4); // eðer dönme ekseni belli olmasaydý  yukardaki forwadla  ile farký cross product a vermemiz gerekiyordu.
            yield return null;
        }
        shoot();
        
    }

    protected IEnumerator lookAt(Transform other) 
    {

        while (Vector3.Angle(turret.forward, (other.position - transform.position)) > 5f)
        {
            turret.Rotate(turret.up * 4); // eðer dönme ekseni belli olmasaydý  yukardaki forwadla  ile farký cross product a vermemiz gerekiyordu.
            yield return null;
        }
    
    }

    protected void shoot()
    {
        var bomb =Instantiate(bombPrefab,bombspawn.position,Quaternion.identity);
        bomb.AddForce(turret.forward*bombspeed);
    }

    protected  void createMoveAffect(float moveAxis)
    {
        mat.mainTextureOffset += new Vector2(moveAxis*0.1f, 0);
    }
}
