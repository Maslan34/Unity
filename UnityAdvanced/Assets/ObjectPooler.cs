using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler instance;
    public List<GameObject> pool;

    public GameObject prefab;
    public int poolCount;
    void Start()
    {
        instance = this;

        AddToPool();
    }

    private void AddToPool()
    {
        pool = new List<GameObject>();

        for (int i = 0; i < poolCount; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject getPoolObject()
    {
        for (int i = 0; i < poolCount; i++)
        {
            if (!pool[i].activeSelf)
                return pool[i];

      
        }
        return null;
    }
}
