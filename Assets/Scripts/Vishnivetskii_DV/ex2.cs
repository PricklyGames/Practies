using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    public int N;
    void Start()
    {
        int[][] massive = new int[N][];
        for (int i = 0; i < N; i++)
        {
            massive[i] = new int[N];
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                massive[i][j] = Random.Range(0, 2);
            }
        }

        for (int i = 0; i < massive.Length; i++)
        {
            for (int j = 0;j < massive.Length; j++)
            {
                if (massive[i][j] == 1)
                {
                    Debug.Log($"Found an element equal to one. Index = {i},{j}");
                }
            }
        }
    }
}
