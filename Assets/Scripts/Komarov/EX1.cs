using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1 : MonoBehaviour
{
    void Start()
    {
        string line = "djklaAadjaA0adajA";
        int countA = 0;
        int length = 0;
        foreach (char c in line)
        {
            if (c == '0')
            {
                print($" Ноль содержится в {length}");
                break;
            }
            if (c == 'A' || c == 'a')
            {
                countA++;
            }
            length++;
        }
        print($"Количество 'A': {countA}, количество букв: {length}");
    }
}
