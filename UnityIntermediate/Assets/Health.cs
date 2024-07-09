using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   public int health = 100;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dealtDamage()
    {
        if (health == 0)
            Debug.Log("You Died");

        if(health>0)
        {
            health -= 5;

            Debug.Log("Health: " + health);
        }
            
    }
}
