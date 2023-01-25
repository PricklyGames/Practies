using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{
    public int row=5;
    void Start()
    {
        int[][] massive = GenerateMas(row);
        for (int i = 0; i < massive.Length; i++)
        {
            for (int j = 0; j < massive[i].Length; j++)
            {
                Debug.Log(massive[i][j]);
            }
        }

        int[][] GenerateMas (int row)
        {
            int[][] massive = new int[row][];

            for (int i = 0; i < row; i++)
            {
                massive[i] = new int[Random.Range(1, 255)];
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < massive[i].Length; j++)
                {
                    massive[i][j] = Random.Range(0, 255);
                }
            }
            return massive;
        }
    }
}
