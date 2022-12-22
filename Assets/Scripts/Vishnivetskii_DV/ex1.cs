using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    public int N;
    void Start()
    {
        int[,] massive = new int[N, N];
        int[] maxmin = new int[2] { 255, 0 };
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                massive[i, j] = Random.Range(0, 100);   
            }   
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (maxmin[1] < massive[i, j])
                {
                    maxmin[1] = massive[i, j];
                }
                if (maxmin[0] > massive[i, j])
                {
                    maxmin[0]= massive[i, j];
                }
            }
            Debug.Log($"The number of elements in the array initially = {massive.Length}.Maximum element = {maxmin[1]} and minimum element = {maxmin[0]}.");
        }
    }
}
