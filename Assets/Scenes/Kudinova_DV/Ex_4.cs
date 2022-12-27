using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_4 : MonoBehaviour
{
    public int stroka, stolb;
    void Start()
    {
        int[,] mas = GenMas(stroka, stolb);
        for (int i = 0; i < stroka; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                Debug.Log(mas[i, j]);
            }
        }

        int[,] GenMas(int stroka, int stolb)
        {
            int[,] mas = new int[stroka, stolb];

            for (int i = 0; i < stroka; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    mas[i, j] = Random.Range(-100, 100);
                }
            }
            return mas;
        }
    }
}
