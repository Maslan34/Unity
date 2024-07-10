using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : Sense
{
    string sensedObject=""; 
    public override void initializeSense()
    {
       
    }

    public override void updateSense()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        sensedObject = other.transform.name;

        Debug.Log("Something Has Been Detected! "+sensedObject);
    }

    private void OnTriggerExit(Collider other)
    {
        sensedObject = "";
    }
}
