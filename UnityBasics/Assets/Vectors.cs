

using System;
using UnityEngine;


public class Vectors : MonoBehaviour
{

    public Transform point1;
    public Transform point2;

    public Transform cubePosition;



    Vector3 Origin = new Vector3(0, 0, 0); // Veya Vector3.zero da ayn� �ey
    Vector3 point1Vector;
    Vector3 point2Vector;
    Vector3 cube;



    void Start()
    {
         

        // GameObject point1 = GameObject.Find("point1");   biz burda public ile al�yoruz
        /*
         * 
         * De�erler burda olunca, bu de�erler oyun ba��nda bir kez al�n�r g�ncellemelerden etkilenmez
         point1Vector = point1.position;
         point2Vector = point2.position;
        */
    }

    // Update is called once per frame
    void Update()
    {
        //Vectors1();
        
        point1Vector = point1.position;
        point2Vector = point2.position;
        cube = cubePosition.position;

        Debug.DrawLine(Origin, point1Vector, Color.yellow);
        Debug.DrawLine(Origin, point2Vector, Color.magenta);


        Vector3 crossProduct = Vector3.Cross(point1Vector, point2Vector);
        Debug.DrawLine(Origin, crossProduct, Color.cyan);

        cubePosition.Rotate(crossProduct,1);


    }








    private void Vectors1()
    {
        point1Vector = point1.position;
        point2Vector = point2.position;

        Debug.DrawLine(Origin, point1Vector, Color.yellow);
        Debug.DrawLine(Origin, point2Vector, Color.magenta);


        float magnitudePoint1 = MathF.Sqrt(MathF.Pow(point1Vector.x, 2) + MathF.Pow(point1Vector.y, 2));
        // veya point1.magnitude yap�labilir.

        float magnitudePoint2 = MathF.Sqrt(MathF.Pow(point2Vector.x, 2) + MathF.Pow(point2Vector.y, 2));


        Vector3 normalizedVector = point1Vector / magnitudePoint1;
        // veya point1Vector.normalized yap�labilir.


        Debug.Log("Vector1 Magnitude-> " + magnitudePoint1);
        Debug.Log("Vector2 Magnitude-> " + magnitudePoint2);
        Debug.Log("Vector1 Normalized-> " + normalizedVector);


        Debug.DrawLine(Origin, normalizedVector, Color.black);

        Vector3 addition = point2Vector + point1Vector;

        Vector3 negativeVector = point2Vector - point1Vector;

        Debug.DrawLine(Origin, addition, Color.cyan);

        Debug.DrawLine(point1Vector, addition, Color.white);


        Debug.DrawLine(Origin, negativeVector, Color.gray);


        float dotProduct = Vector3.Dot(point1Vector, point2Vector);
        Debug.Log("Dot Product-> " + dotProduct);

        // aradaki a��y� bulma:
        /*
         * 
         * a.b = |a|.|b|.cos(theta)
         * 
         * cos(theta)= a.b/ |a|.|b| 
         * 
         * theta = arc(a.b/ |a|.|b| )
         * 
         */


        float thetaRadian = Mathf.Acos(dotProduct / (point1Vector.magnitude * point2Vector.magnitude));

        float degree = thetaRadian * Mathf.Rad2Deg;

        Debug.Log("Degree-> " + degree);




        //Vekt�rlerde  normalizyon i�lemi,vekt�r� b�y�kl��ene b�l�nerek yap�l�r.
        // Burada Daima B�y�kl��� 1 olan fakat y�n� de�i�ebilen vekt�r elde edilir.
    }
}
