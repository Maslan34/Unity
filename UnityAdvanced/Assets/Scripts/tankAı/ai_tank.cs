using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ai_tank : Tank
{
    public NavMeshAgent agent { get { return GetComponent<NavMeshAgent>(); } }

    public Animator fsm { get { return GetComponent<Animator>(); } }

    public Transform[] WayPoints;
    Vector3[] wayPointPos;

    public int index=0;

    private void Start()
    {

        wayPointPos = new Vector3[WayPoints.Length];  
        for(int i = 0; i < WayPoints.Length; i++)
        {
            wayPointPos[i] = WayPoints[i].position;
        }
    }
    protected override void Move()
    {
 
        float distance = Vector3.Distance(transform.position, other.position);
        
        fsm.SetFloat("distance", distance);

        float distancePatrol = Vector3.Distance(transform.position, wayPointPos[index]);
        fsm.SetFloat("distancePatrol", distancePatrol);
    }

    float delay;
    public void Shot()
    {
        Debug.Log("Shot");
        if ((delay += Time.deltaTime) > 1f)
        {
            shoot();
            delay = 0f;
        }
     
    }

    public void Chase()
    {
        Debug.Log("Chase");
        agent.SetDestination(other.position);
    }

    public void Patrol()
    {
        agent.SetDestination(wayPointPos[index]);
        Debug.Log("Patrol");
        //lookAt(other);
       // lookAndShot(other);
    }

    public void FindNewWayPoint()
    {
      switch(index)
        {
            case 0:
                index = 1;
                break;
            case 1:
                index = 0;
                break;
        }

        agent.SetDestination(wayPointPos[index]);
    }
}
