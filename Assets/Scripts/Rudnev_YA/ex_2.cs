using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const float PI = 3.14f;

        float square, radius = 5f;

        square = PI * Mathf.Pow(radius, 2);

        Debug.Log($"Площадь круга равна {square}");
    }

}
