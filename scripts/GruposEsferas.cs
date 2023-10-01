using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruposEsferas : MonoBehaviour
{
    private GameObject[] _esferas;
    private int _furthestIndex;
    
    void Start()
    {
        _esferas = GameObject.FindGameObjectsWithTag("GrupoEsfera1");
        var distances = new float[_esferas.Length];
        for (var i = 0; i < _esferas.Length; i++) {
            distances[i] = Vector3.Distance(transform.position, _esferas[i].transform.position);
        }
        
        var nearestIndex = 0;
        for (var i = 0; i < distances.Length; i++) {
            if (distances[i] > distances[_furthestIndex])
                _furthestIndex = i;
            if (distances[i] < distances[nearestIndex])
                nearestIndex = i;
        }
        _esferas[nearestIndex].transform.position += Vector3.up * 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _esferas[_furthestIndex].GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
