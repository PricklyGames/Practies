using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_1 : MonoBehaviour
{
    public int n;

    void Start()
    {
        int[,] array = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                array[i, j] = Random.Range(-50, 51);
        }

        int min = array[0, 0], max = array[0, 0];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] < min)
                    min = array[i, j];
                if (array[i, j] > max)
                    max = array[i, j];
            }
        }

        int[] numbers = { min, max };

        print("Number of array elements " + n * n);

        print("Minimum and maximum array element:\n");
        for (int i = 0; i < numbers.Length; i++)
            print(numbers[i] + "\t");
    }
}
