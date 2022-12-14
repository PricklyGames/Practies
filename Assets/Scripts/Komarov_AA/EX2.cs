using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2 : MonoBehaviour
{
    void Start()
    {
        const float PI = 3.14f;
        float r = 5;
        float square = PI * r * r;
        print($"The area of the circle is equal to {square}");
    }
}
