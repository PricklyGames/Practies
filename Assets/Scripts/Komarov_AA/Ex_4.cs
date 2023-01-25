using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_4 : MonoBehaviour
{
    public int n, m;

    int[,] CreateArray(int n, int m)
    {
        int[,] array = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                array[i, j] = Random.Range(-50, 51);
        }
        return array;
    }

    void PrintArray(int[,] array, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                print(array[i,j]);
            }
        }
    }

    void Start()
    {
        PrintArray(CreateArray(n, m), n, m);
    }
}
