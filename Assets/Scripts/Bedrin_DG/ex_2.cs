using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_2 : MonoBehaviour
{
    void Start()
    {
        int Radius = 10;
        const float Pi = 3.14f;
        Debug.Log($"Площадь круга равна {Pi * Radius * Radius}");
    }
}
