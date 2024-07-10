using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class vehicle : MonoBehaviour
{
    Path path;
    Vector3 targetPos;
    int index;
    float moveSpeed = 2f;
    public bool isLoop=true;

    void Start()
    {
        path = GameObject.FindAnyObjectByType<Path>();
        SetLookRotation();
        targetPos = path.getPoint(0);
    }

  
    void Update()
    {
        float distance =Vector3.Distance(targetPos,transform.position);

        if(distance < 0.5f)
        {
            SetNewTarget();
            //SetLookRotation(); Lerp eklendiði için update içine alýndý.
        }
        SetLookRotation();
        goTarget();

    }

    private void SetLookRotation()
    {
        Vector3 targetDir = targetPos - transform.position;
        targetDir.Normalize();
        Quaternion lookRotation = Quaternion.LookRotation(targetDir);
        // Ani Dönüþ   transform.rotation = lookRotation;
        transform.rotation = Quaternion.Lerp(transform.rotation,lookRotation,Time.deltaTime*5f);

    }

    private void goTarget()
    {

        float distance = Vector3.Distance(targetPos, transform.position);
        if (distance < 0.3f)
            return;
        Vector3 targetDir = targetPos - transform.position;
        targetDir.Normalize();

        transform.position += targetDir * Time.deltaTime * moveSpeed;

       
    }

    private void SetNewTarget()
    {
        if (isLoop)
        {
            if(index==path.lenghthWayPoints-1)
            {
                index = -1;
            }
        }
        if(index < path.lenghthWayPoints-1)
            index++;
            
        targetPos = path.getPoint(index);
       
    }
}
