using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAleatorio : MonoBehaviour
{
    public int arraySize;
    public int minimumValue;
    public int maximumValue;
    public int[] array;

    private int RandomValue() => Random.Range(minimumValue, maximumValue);

    void Start()
    {
        array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
            array[i] = RandomValue();
    }

    void Update()
    {
        // Cambiamos un valor aleatorio
        array[Random.Range(0, arraySize)] = RandomValue();

        // Mostramos los valores mayores a 15
        string shownValues = "";
        for (int i = 0; i < arraySize; i++)
        {
            if (array[i] > 15)
            {
                shownValues += array[i];
                if (i < arraySize - 1)
                    shownValues += ", ";
            }
        }
        if (shownValues.Length > 0)
            Debug.Log(shownValues);
    }
}
