using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX4 : MonoBehaviour
{
    void Start()
    {
        for (int i = 5; i <= 10; i++)
            print($"{i} x 5 = {i * 5}");
    }
}
