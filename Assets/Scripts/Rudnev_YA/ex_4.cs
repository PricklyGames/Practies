using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_4 : MonoBehaviour
{

    public int row, column;

    // Start is called before the first frame update
    void Start()
    {

        int[,] mas = CreateMas(row, column);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Debug.Log(mas[i, j]);
            }
        }

        // Method

        int[,] CreateMas(int row, int column)
        {
            int[,] mas = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    mas[i, j] = Random.Range(0, 125);
                }
            }

            return mas;
        }

    }

}
