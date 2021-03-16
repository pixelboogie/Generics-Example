using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingGenerics : MonoBehaviour
{
   
    void Start()
    {
        int[] intArray = CreateArray(3, 5);
        Debug.Log("Number of items: " + intArray.Length + ", " + "item1: " + intArray[0] + ", item2: " + intArray[1] + intArray.GetType());

        string[] strArray = CreateArray("Vato", "Loco");
        Debug.Log("Number of items: " + strArray.Length + ", " + "item1: " + strArray[0] + ", item2: " + strArray[1] + strArray.GetType());

    }

    private T[] CreateArray<T>(T item1, T item2)
    {
        return new T [] { item1, item2};
    }

}
