using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBomb : MonoBehaviour
{
    

    float delay = 1f;
    float elapsedTime = 0f;
    public GameObject prefab;
    public Transform spawn;


    //void Update()
    //{

    //    if ((elapsedTime += Time.deltaTime) > delay)
    //    {
    //        var bomb = Instantiate(prefab, spawn.position,prefab.transform.rotation);

    //        bomb.GetComponent<Rigidbody>().AddForce(spawn.forward* 50f);
    //    }


    //}

    void Update()
    {

            GameObject bomb = ObjectPooler.instance.getPoolObject();
            if (bomb != null)
            {
                bomb.transform.position = spawn.position;
                bomb.transform.rotation = spawn.rotation;
                bomb.SetActive(true);
                bomb.GetComponent<Rigidbody>().AddForce(spawn.forward * 50f);
            }
        
     

         


    }
}
