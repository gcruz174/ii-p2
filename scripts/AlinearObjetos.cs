using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlinearObjetos : MonoBehaviour
{
    public GameObject cubo;
    public GameObject cilindro;

    void Start()
    {
        cubo.transform.position = transform.position + new Vector3(5, 0, 0);
        cilindro.transform.position = transform.position + new Vector3(-5, 0, 0);
    }
}
