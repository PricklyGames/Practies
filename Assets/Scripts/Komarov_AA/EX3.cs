using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX3 : MonoBehaviour
{
    void Start()
    {
        float height = 7, width = 5, main_square = 20;
        float square = height * width;
        if (square > main_square)
        {
            print($"The area found is equal to {square}");
            print($"The found are is larger than the one specified on {square - main_square}");
        }
    }
}
