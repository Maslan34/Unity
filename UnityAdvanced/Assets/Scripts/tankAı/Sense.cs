using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Sense : MonoBehaviour, ISense
{
    public abstract void  initializeSense();
  

    public abstract void  updateSense();
    // Start is called before the first frame update
    void Start()
    {
        initializeSense();
    }

    // Update is called once per frame
    void Update()
    {
        updateSense();
    }
}
