using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public LineRenderer line { get{ return GetComponent<LineRenderer>(); } }

    public Transform[] wayPoints;
    Vector3[] wayPointPos;
    void Awake()
    {
        wayPointPos = new Vector3[wayPoints.Length];
        line.positionCount = wayPoints.Length;
        for (int i = 0; i < wayPoints.Length; i++)
        {
            wayPointPos[i] = wayPoints[i].position;
           

        }
        line.SetPositions(wayPointPos);
    }

    public Vector3 getPoint(int index)
    {
        return wayPointPos[index];
    }

    public int lenghthWayPoints { get{ return wayPoints.Length; } }
}
