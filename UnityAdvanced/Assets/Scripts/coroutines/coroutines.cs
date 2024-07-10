using System.Collections;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    private string message = "Muharrem Aslan";

    public Transform target;
    float moveSpeed = 3f;
    public Transform[] waypoints;
    Vector3[] wayPointPosisitons; 

    void Start()
    {
        // DoSomething();

        // StartCoroutine(DoSomething());
        // Debug.Log("Next");

        //StartCoroutine(StartDialog()); 

        wayPointPosisitons = new Vector3[waypoints.Length];

        for (int i = 0; i < wayPointPosisitons.Length; i++)
        {
            wayPointPosisitons[i] = waypoints[i].position;
        }

        StartCoroutine(MoveWayPoints(wayPointPosisitons));
        StartCoroutine(MoveToTarget(target.position,moveSpeed));
    }


    IEnumerator current;
    void Update()
    {
       if(Input.GetKeyUp(KeyCode.Space)) {
        
            if(current != null) {
            
                StopCoroutine(current);
            }
            current = MoveToTargetRandom(Random.insideUnitCircle*5,moveSpeed);
            StartCoroutine(current);
        }

    }

    private IEnumerator DoSomething() //-> Fonksiyonlarý parçalara bölünür.
    {
        while (true)
        {
            Debug.Log("Hi");
            yield return new WaitForSeconds(2f);
        }
    }

    private IEnumerator StartDialog()
    {
        int index = 0;
        while (index < this.message.Length)
        {
            Debug.Log(this.message[index]);
            index++;
            yield return new WaitForSeconds(0.3f);
        }
    }

    private IEnumerator MoveToTarget(Vector3 target , float moveSpeed)
    {
        while(transform.position != target)
        {
            transform.position = Vector3.MoveTowards(transform.position,target,Time.deltaTime*moveSpeed);
            yield return null;
        }

        Debug.Log("Done!");
    }

    private IEnumerator MoveToTargetRandom(Vector3 target, float moveSpeed)
    {
        while (transform.position != target)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * moveSpeed);
            yield return null;
        }

        Debug.Log("Done Random!");
    }

    private IEnumerator MoveWayPoints(Vector3[] wayPoints)
    {
       foreach (Vector3 t in wayPoints)
        {
            MoveToTarget(t,moveSpeed);
            yield return null;
        }

        Debug.Log("Done WayPoints!");
    }

}