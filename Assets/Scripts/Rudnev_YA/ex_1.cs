using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_1 : MonoBehaviour
{
    public int N;

    // Start is called before the first frame update
    void Start()
    {

        int[,] mas = new int[N, N];
        int[] minAndMaxEl = new int[2] { 255, -1 };

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                mas[i, j] = Random.Range(0, 125);
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
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

        Debug.Log($"Number of elements of the original array: {mas.Length}. Minimum element {minAndMaxEl[0]}. Maximum element {minAndMaxEl[1]}.");

    }

}
