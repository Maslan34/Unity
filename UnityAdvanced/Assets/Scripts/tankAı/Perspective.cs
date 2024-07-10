using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perspective : Sense
{

    float fieldOfView = 60f;
    float maxDistance = 40f;
    public Transform other;
    Animator fsm;

    public override void initializeSense()
    {
        
    }

    public override void updateSense()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        fsm = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // fark vektörü
      
        Vector3 dir = (other.position - transform.position).normalized;
        
        float difference = Vector3.Angle(dir, transform.forward);

        Debug.DrawRay(transform.position, transform.forward*maxDistance, Color.black);

        Debug.DrawRay(transform.position, dir * maxDistance, Color.red);
        if (difference < fieldOfView/2) 
        {
            Ray ray = new Ray(transform.position,dir);
            
            if(Physics.Raycast(ray,out RaycastHit hitinfo,maxDistance))
            {

                Debug.DrawRay(transform.position, dir * maxDistance, Color.yellow);
                string name = hitinfo.transform.name;
                Debug.Log(name);
                if (name.Equals("playerTank"))
                    fsm.SetBool("visible", true);
                else
                    fsm.SetBool("visible", false);

            }
            else
                fsm.SetBool("visible", false);



        }

    }
}
