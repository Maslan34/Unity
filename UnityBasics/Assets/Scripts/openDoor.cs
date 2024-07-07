using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{


    private GameObject car;
    private GameObject door;
    private void Start()
    {
        car=GameObject.Find("car");
        door = GameObject.Find("door");
    }
    
    void Update()
    {
        car.transform.position += new Vector3(Time.deltaTime * 5, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        door.gameObject.transform.position += Vector3.up * 5;
    }

    /* Hata gidip geliyor dikkat 
    private void OnTriggerExit(Collider other)
    {
        door.gameObject.transform.position -= Vector3.up * 5;
    }
    */
}
