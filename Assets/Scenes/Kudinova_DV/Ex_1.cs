using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ex_1 : MonoBehaviour
{
    public int Length;
    private void Start()
    {
        int[,] mas = new int[Length, Length];
        int[] maxmin = new int[]
        {
            int.MinValue,
            int.MaxValue,
        };
        string result = "";
        
        for (int i = 0; i < Length; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                int rnd = UnityEngine.Random.Range(-100, 100);
                mas[i, j] = rnd;
                if (maxmin[0] < rnd)
                {
                    maxmin[0] = rnd;
                }
                if (maxmin[1] > rnd)
                {
                    maxmin[1] = rnd;
                }
                result += $"{mas[i, j]} ";
            }
        }
        print(result);
        print($"{maxmin[0]},{maxmin[1]} ");
    }
}
