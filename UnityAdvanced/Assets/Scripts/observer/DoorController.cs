using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isRegistered=false;
    public int id;

    void Start()
    {
        if (isRegistered)
        {
            Register();
           
        }
             
    }

    private void Register()
    {
        GameEvents.instance.onDoorTriggerEnter += Ýnstance_onDoorTriggerEnter;
        GameEvents.instance.onDoorTriggerExit += Ýnstance_onDoorTriggerExit;
        isRegistered = true;
    }

    private void UnRegister()
    {
        GameEvents.instance.onDoorTriggerEnter -= Ýnstance_onDoorTriggerEnter;
        GameEvents.instance.onDoorTriggerExit -= Ýnstance_onDoorTriggerExit;
        isRegistered = false;
    }

    private void OnDestroy()
    {
        UnRegister();
    }
    private void Ýnstance_onDoorTriggerExit(int id)
    {
        if (this.id == id)
        {
            LeanTween.moveLocalY(gameObject, 0f, 1f).setEaseInOutSine();
        }
    }

    private void Ýnstance_onDoorTriggerEnter(int id)

    {
        if(this.id == id)
        {
            LeanTween.moveLocalY(gameObject, 5f, 1f).setEaseInOutBounce();
        }
      
    }

    private void OnMouseDown()
    {
      
        if (isRegistered)
        {
            UnRegister();
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            Register();
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
            
    }


}
