using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    private Renderer _renderer;
    public KeyCode keyCode;
    
    void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
            _renderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
