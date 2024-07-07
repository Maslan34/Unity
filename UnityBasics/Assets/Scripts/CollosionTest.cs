
using UnityEngine;

public class CollosionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("De�me Ba�lad� RigidBodysi olan obje i�in");
        
       Renderer mshRenderer =collision.gameObject.GetComponent<MeshRenderer>();

        Transform trns = collision.gameObject.GetComponent<Transform>(); 
        mshRenderer.material.color = Color.red;
        //trns.Rotate(0, 0, 10);

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("i�inde ge�me Ba�lad� RigidBodysi olmayan obje i�in");

        Renderer mshRenderer = other.gameObject.GetComponent<MeshRenderer>();

        mshRenderer.material.color = Color.black;
    }

}
