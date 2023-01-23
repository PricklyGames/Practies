using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_5 : MonoBehaviour
{
    [SerializeField] private int _lines;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EX-5");
        int[][] array;
        if (_lines > 0)
        {
            array = CreateArray(_lines);
        }
        else
        {
        array = CreateArray();
        }
        for(int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Debug.Log($"array[{i}][{j}]={array[i][j]}");
            }
        }
    }

    // Update is called once per frame
    int[][] CreateArray(int lines=10)
    {
        int[][] array = new int[lines][];
        for (int i = 0; i < lines; i++)
        {
            array[i] = new int[Random.Range(1, lines + 1)];
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][ j] = Random.Range(0, 100);
            }
        }
        return array;
    }
}
