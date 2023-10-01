using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanciaEsfera : MonoBehaviour
{
    public GameObject cubo;
    public GameObject cilindro;
    
    void Start()
    {
        Debug.Log("La distancia de la esfera al cubo es: " + Vector3.Distance(transform.position, cubo.transform.position));
        Debug.Log("La distancia de la esfera al cilindro es: " + Vector3.Distance(transform.position, cilindro.transform.position));    
    }
}
