using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_5 : MonoBehaviour
{
    public int n = 5;

    int[][] CreateArray(int n)
    {
        int[][] array = new int[n][];

        for (int i = 0; i < n; i++)
            array[i] = new int[Random.Range(0, 11)];

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
                array[i][j] = Random.Range(-50, 51);
        }

        return array;
    }

    void PrintArray(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                print(array[i][j]);
            }
            print("\n");
        }
    }

    void Start()
    {
        PrintArray(CreateArray(n));
    }
}
