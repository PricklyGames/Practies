using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Ex_2 : MonoBehaviour
{
    public int Len;
    private void Start()
    {
        int[][] mas = new int[Len][];
        string result = "";
        for (int i = 0; i < Len; i++)
        {
            mas[i] = new int[Len];
        }
        for (int i = 0; i < Len; i++)
        {
            for ( int j = 0; j < Len; j++)
            {
                mas[i][j] = Random.Range(0, 2);
            }
        }
        for ( int i = 0; i < mas.Length; i++)
        {
            for ( int j = 0; j < mas.Length; j++)
            {
                if (mas[i][j] == 1)
                {
                    print($"{i}, {j} ");
                }
                result += $"{mas[i][j]} ";
            }
        }
        print(result);
    }
}
