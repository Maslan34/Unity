using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{

    public static GameEvents instance; // Direk objeye eriþim için kullanýldý.


    void Start()
    {
        instance = this; // ilk oluþturulmada buraya atandý.
    }

    //public event Action onDoorTriggerEnter;
    //public event Action onDoorTriggerExit;

    public event Action<int> onDoorTriggerEnter;
    public event Action<int> onDoorTriggerExit;

    public void DoorTriggerEnter(int id)
    {
       if (onDoorTriggerEnter != null)
        {
            onDoorTriggerEnter(id);
        }
  
    }


    public void DoorTriggerExit(int id)
    {
        if (onDoorTriggerExit != null)
        {
            onDoorTriggerExit(id);
        }
    }

    
}
