using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("N4");
        for (int i = 5; i <= 10; i++)
        {
            Debug.Log($"{i}X5={i * 5}");
        }
    }
}