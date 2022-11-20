using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX3 : MonoBehaviour
{
    void Start()
    {
        int w = 5;
        int h = 7;
        int s1 = w * h;
        int s2 = 30;

        if (s1 > s2)
        {
            print($"Ќайденна€ площадь ({s1}) больше чем заданна€ ({s2}), разница: {s1 - s2}");
        }
    }
}
