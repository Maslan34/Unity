using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{

    private void Awake()
    {
       // Debug.Log("Awake Funct In");
    }
    void Start()
    {
        // Debug.Log("Start Funct In");
    }

    private void OnDisable()
    {
      //  Debug.Log("File Disabled!");
    }

    private void OnEnable()
    {
       // Debug.Log("File Enabled!");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update Funct In");
    }

    private void FixedUpdate()
    {
     //   Debug.Log("FixedUpdate Funct In -> Only Purpose for Pyhsical Process");
    }


    private void LateUpdate()
    {
        //Debug.Log("LateUpdate Funct In -> Only Purpose for Camera Process");
        //Camera.main.transform.position += Vector3.right * Time.deltaTime * 2; //Her saniye 2 birim saða 
        Camera.main.transform.position += Vector3.right * (1f/Time.deltaTime) * 2; 
        //Debug.Log(Camera.main.transform.position);
        //Camera.main.transform.position += Vector3.forward * Time.deltaTime * 2 ;//Her saniye 2 birim öne 
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy Funct In --> Works when app finishs its process");
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(500, 0, 100, 50), "Click me")){
            Debug.Log("Clicked");
        }
    }
}
