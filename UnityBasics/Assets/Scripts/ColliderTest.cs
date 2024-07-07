
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("içinde geçme Baþladý RigidBodysi olmayan obje için");

        Renderer mshRenderer = other.gameObject.GetComponent<MeshRenderer>();
        BoxCollider collider = other.gameObject.GetComponent<BoxCollider>();
        // collider.isTrigger = false; !!! 

        mshRenderer.material.color = Color.black;
    }
    private void OnTriggerStay(Collider other)
    {
    
    }

    private void OnTriggerExit(Collider other)
    {
      
    }
}
