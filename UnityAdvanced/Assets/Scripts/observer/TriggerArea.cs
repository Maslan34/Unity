using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    // Start is called before the first frame update

    public int id;

    private void OnTriggerEnter(Collider other)
    {
        GameEvents.instance.DoorTriggerEnter(id);

    }

    private void OnTriggerExit(Collider other)
    {
        GameEvents.instance.DoorTriggerExit(id);
    }
}
