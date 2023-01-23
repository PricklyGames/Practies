using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_2 : MonoBehaviour
{
    [SerializeField] private int _n;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EX-2");
        int[][] array = new int[_n][];
        for (int i = 0; i < _n; i++)
        {
            array[i] = new int[_n];
        }

        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                array[i][ j] = Random.Range(0, 2);
            }
        }
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                if (array[i][j] == 1) { Debug.Log($"One is found at i={i},j={j}"); }
            }
        }
    }

    // Update is called once per frame

}
