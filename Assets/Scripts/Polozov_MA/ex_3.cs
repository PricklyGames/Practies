using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_3 : MonoBehaviour
{
    [SerializeField] private int _n;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EX-3");
        int[,] array1 = new int[_n, _n];//ex-1 start
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                array1[i, j] = Random.Range(0, 100);
            }
        }
        int[] min_max = MinMax(array1);
        Debug.Log($"Size of array:{array1.Length},Minimum:{min_max[0]}, Maximum:{min_max[1]}");
        //ex-1 end

        int[][] array2 = new int[_n][];//ex-2 start
        for (int i = 0; i < _n; i++)
        {
            array2[i] = new int[_n];
        }

        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                array2[i][j] = Random.Range(0, 2);
            }
        }
        OneFounder(array2);//ex-2 end

    }
int[] MinMax(int[,] array)
    {
        int[] min_max = { 101, -1 };
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                min_max[0] = array[i, j] < min_max[0] ? array[i, j] : min_max[0];
                min_max[1] = array[i, j] > min_max[1] ? array[i, j] : min_max[1];
            }
        }
        return min_max;
    }
    void OneFounder(int[][] array)
    {
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                if (array[i][j] == 1) { Debug.Log($"One is found at i={i},j={j}"); }
            }
        }
    }
}
