using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_4 : MonoBehaviour
{
    [SerializeField] private int _lines, _columns;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EX-4");
        int[,] array = CreateArray(_columns, _lines);
        for(int i = 0; i < _lines; i++)
        {
            for(int j=0;j<_columns; j++)
            {
                Debug.Log($"array[{i},{j}]={array[i, j]}");
            }
        }
    }

    // Update is called once per frame
 int[,] CreateArray(int columns,int lines)
    { int[,] array =new int[lines, columns];
        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = Random.Range(0, 100);
            }
        }
        return array;
    }
}
