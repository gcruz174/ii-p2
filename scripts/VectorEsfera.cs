using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorEsfera : MonoBehaviour
{
    public Vector3 firstVector = new Vector3(1, 2, 3);
    public Vector3 secondVector = new Vector3(4, 5, 6);
    
    void Start()
    {
        Debug.Log("Magnitud firstVector: " + firstVector.magnitude);
        Debug.Log("Magnitud secondVector: " + secondVector.magnitude);
        Debug.Log("Angulo entre los vectores: " + Vector3.Angle(firstVector, secondVector));
        Debug.Log("Distancia entre los vectores: " + Vector3.Distance(firstVector, secondVector));
        Debug.Log("Vector a mayor altura: " + (firstVector.y > secondVector.y ? "firstVector" : "secondVector"));
        Debug.Log("Posicion de la esfera: " + transform.position);
    }
}
