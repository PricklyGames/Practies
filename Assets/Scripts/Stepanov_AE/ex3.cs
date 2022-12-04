using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        double square_1 = 25; 

        double length = 7;
       
        double width = 10;

        double square_2;

        square_2 = length * width;

        Debug.Log("Заданная площадь: " + square_1);
        Debug.Log("Рассчитанная площадь: " + square_2);  

        if (square_2 > square_1)
        {
            Debug.Log("Большая площадь:" + square_2);
            Debug.Log($"Разница между squareами = {square_2 - square_1}");

        }


    }
}


