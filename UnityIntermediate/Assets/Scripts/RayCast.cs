using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shot", 2f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        /*

        if (Physics.Raycast(transform.position, Vector3.down)) {

            Debug.Log("A�a��da Bir Nesne Var");
        
        }

        */


        /*
        Ray ray = new Ray(transform.position, Vector3.down);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray,out hitInfo))
        {

            Debug.Log("A�a��da Bir "+ hitInfo.transform.name +" Var");

        }
        */


        // Manip�le Edilebilir.

        /*
        Ray ray = new Ray(transform.position, Vector3.down);

        RaycastHit hitInfo;


        if (Physics.Raycast(ray, out hitInfo))
        {
            hitInfo.transform.name = "x";

            Debug.Log("A�a��da Bir " + hitInfo.transform.name + " Var");

        }

        */
       

    }

    private void Shot()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            Health healthComponent = hitInfo.transform.GetComponent<Health>();
            if (healthComponent != null)
            {
                healthComponent.dealtDamage(); // Sa�l�k de�i�kenini do�rudan azalt�n.
                Debug.Log("A�a��da bir " + hitInfo.transform.name + " var. Sa�l�k: " + healthComponent.health);
            }
        }
    }
}
