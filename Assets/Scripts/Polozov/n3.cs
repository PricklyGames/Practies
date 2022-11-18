using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n3 : MonoBehaviour
{
    [SerializeField] int Length;
    [SerializeField] int Height;
    [SerializeField] int Square;
    // Start is called before the first frame update
    void Start()
    {
        int Square2 = Length * Height;
        if (Square2 > Square)
        {
            Debug.Log("N3:");
            Debug.Log($"Square zad {Square},Square calc {Square2}, Difference {Square2 - Square}");
        }
    }

}
