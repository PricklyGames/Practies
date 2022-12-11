using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_3 : MonoBehaviour
{

    public int NMas_1, NMas_2;

    // Start is called before the first frame update
    void Start()
    {
        // First task
        int[,] mas_1 = new int[NMas_1, NMas_1];
        int[] minAndMaxEl = new int[2] { 255, -1 };

        for (int i = 0; i < NMas_1; i++)
        {
            for (int j = 0; j < NMas_1; j++)
            {
                mas_1[i, j] = Random.Range(0, 125);
            }
        }

        Ex1(mas_1, ref minAndMaxEl);
        Debug.Log($"Number of elements of the original array: {mas_1.Length}. Minimum element {minAndMaxEl[0]}. Maximum element {minAndMaxEl[1]}.");

        // Second task

        int[][] mas_2 = new int[NMas_2][];

        for (int i = 0; i < NMas_2; i++)
        {
            mas_2[i] = new int[NMas_2];
        }

        for (int i = 0; i < NMas_2; i++)
        {
            for (int j = 0; j < NMas_2; j++)
            {
                mas_2[i][j] = Random.Range(0, 2);
            }
        }

        Ex2(mas_2);

        // Methods

        void Ex1 (int [,] mas, ref int[] minAndMaxEl)
        {

            for (int i = 0; i < NMas_1; i++)
            {
                for (int j = 0; j < NMas_1; j++)
                {
                    if (minAndMaxEl[0] > mas[i, j])
                    {
                        minAndMaxEl[0] = mas[i, j];
                    }

                    if (minAndMaxEl[1] < mas[i, j])
                    {
                        minAndMaxEl[1] = mas[i, j];
                    }
                }
            }

        }

        void Ex2 (int [][] mas)
        {
            for (int i = 0; i < NMas_2; i++)
            {
                for (int j = 0; j < NMas_2; j++)
                {
                    if (mas[i][j] == 1)
                    {
                        Debug.Log($"An element equal to one is found, its index is {i} {j}.");
                    }
                }
            }
        }

    }

}
