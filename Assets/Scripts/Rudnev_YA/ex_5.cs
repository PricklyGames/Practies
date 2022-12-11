using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_5 : MonoBehaviour
{

    public int row;

    // Start is called before the first frame update
    void Start()
    {

        int[][] mas = CreateMas(row);

        for (int i = 0; i < mas.Length; i++)
        {
            for (int j = 0; j < mas[i].Length; j++)
            {
                Debug.Log(mas[i][j]);
            }
        }

        // Method

        int [][] CreateMas (int row = 5)
        {
            int[][] mas = new int[row][];

            for (int i = 0; i < row; i++)
            {
                mas[i] = new int[Random.Range(1, 10)];
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    mas[i][j] = Random.Range(0, 125);
                }
            }

            return mas;
        }

    }

}
