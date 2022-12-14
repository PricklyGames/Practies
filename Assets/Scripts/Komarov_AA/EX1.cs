using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1 : MonoBehaviour
{
    void Start()
    {
        string line = "AfdfaaAdsa0Adadf";
        int countA = 0, length = 0;
        foreach (char c in line)
        {
            if (c == '0')
            {
                print($"The line has '0', index {length}");
                break;
            }
            if (c == 'A' || c == 'a')
                countA++;
            length++;
        }
        print($"Number of characters a = {countA}, Line length = {length}");
    }
}
