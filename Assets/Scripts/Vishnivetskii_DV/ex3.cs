using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
    public int Narray_1, Narray_2;
    void Start()
    {
        int[,] array_1 = new int[Narray_1, Narray_1];
        int[] maxmin = new int[2] { 255, 0 };
        for (int i = 0; i < Narray_1; i++)
        {
            for (int j = 0; j < Narray_1; j++)
            {
                array_1[i, j] = Random.Range(0, 100);
            }
        }
        Exercise1(array_1, ref maxmin);
        Debug.Log($"The number of elements in the array initially = {array_1.Length}.Maximum element = {maxmin[1]} and minimum element = {maxmin[0]}.");


        int[][] array_2 = new int[Narray_2][];
        for (int i = 0; i < Narray_2; i++)
        {
            array_2[i] = new int[Narray_2];
        }

        for (int i = 0; i < Narray_2; i++)
        {
        for (int j = 0; j < Narray_2; j++)
            {
                array_2[i][j] = Random.Range(0, 2);
            }
        }
        Exercise2(array_2);
     

        void Exercise1 (int[,] array, ref int[] maxmin)
        {
            for (int i = 0; i < Narray_1; i++)
            {
                for (int j = 0; j < Narray_1; j++)
                {
                    if (maxmin[1] < array[i, j])
                    {
                        maxmin[1] = array[i, j];
                    }
                    if (maxmin[0] > array[i, j])
                    {
                        maxmin[0] = array[i, j];
                    }
                }
            }
        }
        
        void Exercise2(int[][] array)
        {
            for (int i = 0; i < array_2.Length; i++)
            {
                for (int j = 0; j < array_2.Length; j++)
                {
                    if (array_2[i][j] == 1)
                    {
                        Debug.Log($"Found an element equal to one. Index = {i},{j}");
                    }
                }
            }
        }
    }
}
