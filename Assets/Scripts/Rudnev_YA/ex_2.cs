using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_2 : MonoBehaviour
{
    public int N;

    // Start is called before the first frame update
    void Start()
    {

        int[][] mas = new int[N][];

        for (int i = 0; i < N; i++)
        {
            mas[i] = new int[N];
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                mas[i][j] = Random.Range(0, 2);
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (mas[i][j] == 1)
                {
                    Debug.Log($"An element equal to one is found, its index is {i} {j}.");
                }
            }
        }

    }

}
