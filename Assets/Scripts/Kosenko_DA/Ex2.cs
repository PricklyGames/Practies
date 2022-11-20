using System;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    private float _radius = 5;

    void Awake()
    {
        Debug.Log("Exercise #2. START.");

        Debug.Log(String.Format("Area of the circle with radius of {0} is equal to {1:0.##}.", _radius, Mathf.PI * Mathf.Pow(_radius, 2)));

        Debug.Log("Exercise #2. END.");
    }
}
