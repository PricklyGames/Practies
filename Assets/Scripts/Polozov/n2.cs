using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class n2 : MonoBehaviour
{
    [SerializeField] int Radius;
    // Start is called before the first frame update
    void Start()
    {
        double Square = Radius * Radius * Math.PI;
        Debug.Log($"N2:\n square={Square}");
    }


}
