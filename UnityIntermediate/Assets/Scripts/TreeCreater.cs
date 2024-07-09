
using UnityEngine;

public class TreeCreater : MonoBehaviour
{


    // Prefab'a ihtiyaç var,public olarak alýyoruz.

    public GameObject prefab;

    void Start()
    {
        Instantiate(prefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

          GameObject go = Instantiate(prefab);
            float randX = Random.Range(-3, 3);
            float randZ = Random.Range(-3, 3);
            Vector3 vt= new Vector3 (randX, 0f, randZ);
            go.GetComponent<Transform>().position = vt;


            // 5 saniye sonra yok edilecek;
            Destroy(go,5f);

        }
            
      
    }

   
}
