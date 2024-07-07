
using UnityEngine;

public class CollosionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Deðme Baþladý RigidBodysi olan obje için");
        
       Renderer mshRenderer =collision.gameObject.GetComponent<MeshRenderer>();

        Transform trns = collision.gameObject.GetComponent<Transform>(); 
        mshRenderer.material.color = Color.red;
        //trns.Rotate(0, 0, 10);

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("içinde geçme Baþladý RigidBodysi olmayan obje için");

        Renderer mshRenderer = other.gameObject.GetComponent<MeshRenderer>();

        mshRenderer.material.color = Color.black;
    }

}
