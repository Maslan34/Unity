using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallCreater : MonoBehaviour
{

    public GameObject prefab;

    void Start()
    {

        //Bu fonksiyon oyun ba�lay�n 4 saniye sonra �al��t�rl�r ve 1 top atar sadece 
        Invoke("createBall", 4f);
        InvokeRepeating("createBall", 8f,1f); //8 saniye sonra bu fonk �a�r�l�r ve
                                              //sonra her saniye 1 saniye sonra
                                              //tekrar tekrar �al���t�r�l�r. 
                                              //Startda olmas�na ra�men 
                                              // update gibi hep tekrarlan�r.
    }

    // Update is called once per frame
    void Update()
    {



        /*
        if (Input.GetKeyDown(KeyCode.Backspace))
        {

            GameObject go = Instantiate(prefab);
            go.GetComponent<Rigidbody>().AddForce(new Vector3(1000, 0, 0));
         
      

            // 5 saniye sonra yok edilecek;
            Destroy(go, 3f);

        }
        */
    }

    void createBall() {

        GameObject go = Instantiate(prefab);
        go.GetComponent<Rigidbody>().AddForce(new Vector3(1000, 0, 0));

        Destroy(go, 3f);

    }
}
