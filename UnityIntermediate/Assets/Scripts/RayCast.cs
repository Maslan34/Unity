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

            Debug.Log("Aþaðýda Bir Nesne Var");
        
        }

        */


        /*
        Ray ray = new Ray(transform.position, Vector3.down);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray,out hitInfo))
        {

            Debug.Log("Aþaðýda Bir "+ hitInfo.transform.name +" Var");

        }
        */


        // Manipüle Edilebilir.

        /*
        Ray ray = new Ray(transform.position, Vector3.down);

        RaycastHit hitInfo;


        if (Physics.Raycast(ray, out hitInfo))
        {
            hitInfo.transform.name = "x";

            Debug.Log("Aþaðýda Bir " + hitInfo.transform.name + " Var");

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
                healthComponent.dealtDamage(); // Saðlýk deðiþkenini doðrudan azaltýn.
                Debug.Log("Aþaðýda bir " + hitInfo.transform.name + " var. Saðlýk: " + healthComponent.health);
            }
        }
    }
}
