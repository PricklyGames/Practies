using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_6 : MonoBehaviour
{
    void Start()
    {
        Start2(1);
        void Start2( int number)
        {
            int num;
            int num1;
            Ref(out num, out num1);
        }
        void Ref(out int number, out int number1)
        {
            number = UnityEngine.Random.Range(-100,100);
            number1 = UnityEngine.Random.Range(-100, 100);
            int y = (number + number1);
            print(y);
        }
    }
}
