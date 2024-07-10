using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     float moveSpeed =10f;
     float rotationSpeed =240f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAxis = Input.GetAxis("Vertical");
        float rotAxis = Input.GetAxis("Horizontal");

        transform.position += transform.forward * moveAxis * moveSpeed*Time.deltaTime;
        transform.rotation *= Quaternion.Euler(Vector3.up *rotAxis* rotationSpeed * Time.deltaTime);
    }
}
