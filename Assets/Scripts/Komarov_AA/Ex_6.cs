using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_6 : MonoBehaviour
{
    void Start()
    {
        int value = 0;

        Generation1(value);
        print(value);

        Generation2(ref value);
        print(value);

    }

    void Generation1(int number)
    {
        number = Random.Range(-100, 101);
    }

    void Generation2(ref int number)
    {
        number = Random.Range(-100, 101);
    }
}
