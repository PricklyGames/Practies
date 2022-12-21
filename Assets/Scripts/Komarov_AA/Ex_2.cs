using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_2 : MonoBehaviour
{
    public int n;

    void Start()
    {
        int[][] array = new int[n][];

        for (int i = 0; i < n; i++)
            array[i] = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i][j] = Random.Range(0, 2);
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i][j] == 1)
                    print($"Index of an array element equal to '1': [{i}][{j}].\n");
            }
        }
        
        
    }
}
