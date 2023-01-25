using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 0;

        Generator1(number);
        print(number);
        Generator2(ref number);
        print(number);

    }

    void Generator1(int number)
    {
        number = Random.Range(-999,999);
    }

    void Generator2(ref int number)
    {
        number = Random.Range(-999, 999);
    }
}
