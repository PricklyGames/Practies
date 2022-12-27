using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_3 : MonoBehaviour
{
    public int Len1, Len2;
    void Start()
    {
        int[,] mas1 = new int[Len1, Len1];
        string result1 = "";
        string result2 = "";
        int[] maxmin = new int[]
        {
            int.MinValue,
            int.MaxValue,
        };

        for (int i = 0; i < Len1; i++)
        {
            for (int j = 0; j < Len1; j++)
            {
                mas1[i, j] = Random.Range(-100, 100);
            }
        }
        Zadaine1(mas1, ref maxmin);
        Debug.Log($" Максимум = {maxmin[0]}, минимум = {maxmin[1]}, массив = {result1} .");


        int[][] mas2 = new int[Len2][];
        for (int i = 0; i < Len2; i++)
        {
            mas2[i] = new int[Len2];
        }

        for (int i = 0; i < Len2; i++)
        {
            for (int j = 0; j < Len2; j++)
            {
                mas2[i][j] = Random.Range(0, 2);
            }
        }
        Zadanie2(mas2);


        void Zadaine1(int[,] mas, ref int[] maxmin)
        {
            for (int i = 0; i < Len1; i++)
            {
                for (int j = 0; j < Len1; j++)
                {
                    if (maxmin[0] < mas[i, j])
                    {
                        maxmin[0] = mas[i, j];
                    }
                    if (maxmin[1] > mas[i, j])
                    {
                        maxmin[1] = mas[i, j];
                    }
                    result1 += $"{mas1[i, j]} ";
                }
            }
        }

        void Zadanie2(int[][] mas)
        {
            for (int i = 0; i < mas2.Length; i++)
            {
                for (int j = 0; j < mas2.Length; j++)
                {
                    if (mas2[i][j] == 1)
                    {
                        Debug.Log($"{i},{j}");
                    }
                    result2 += $"{mas2[i][j]} ";
                }
            }
            print(result2);
        }
    }
}