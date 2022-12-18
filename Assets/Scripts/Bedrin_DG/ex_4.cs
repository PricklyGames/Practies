using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_4 : MonoBehaviour
{
    void Start()
    {
        for (int i = 5; i < 11; i++)
        {
            for (int s = 5; s < 11; s++)
            {
                Debug.Log($"{i}*{s}={i * s}");
            }
        }
    }
}
