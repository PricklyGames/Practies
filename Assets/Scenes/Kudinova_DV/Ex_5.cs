using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_5 : MonoBehaviour
{
    public int row = 5;
    void Start()
    {
        int[][] mas = GenMas(row);
        for (int i = 0; i < mas.Length; i++)
        {
            for (int j = 0; j < mas[i].Length; j++)
            {
                Debug.Log(mas[i][j]);
            }
        }

        int[][] GenMas(int row)
        {
            int[][] mas = new int[row][];

            for (int i = 0; i < row; i++)
            {
                mas[i] = new int[Random.Range(1, 255)];
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    mas[i][j] = Random.Range(0, 255);
                }
            }
            return mas;
        }
    }
}