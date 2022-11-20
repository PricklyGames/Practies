using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2 : MonoBehaviour
{
    void Start()
    {
        const float p = 3.14f;
        float r = 5;

        float sq = p * r * r;
        print($"Площадь = {sq}");
    }
}
