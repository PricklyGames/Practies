using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    public int row, column;
    void Start()
    {
        int[,] Array = GenerateMas(row, column);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Debug.Log(Array[i,j]);
            }
        }

        int[,] GenerateMas (int row, int column)
        {
            int[,] Array = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Array[i,j] = Random.Range(0, 255);
                }
            }
        return Array;
        }
    }
}
