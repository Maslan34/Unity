using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{

    public static GameEvents instance; // Direk objeye eri�im i�in kullan�ld�.


    void Start()
    {
        instance = this; // ilk olu�turulmada buraya atand�.
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
