using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_1 : MonoBehaviour
{
    [SerializeField] private int _n;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EX-1");
        int[,] array = new int[_n, _n];
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++) {
                array[i, j] = Random.Range(0, 100);
            } }
        int[] min_max = { 101, -1 };
        for (int i = 0; i < _n; i++) { 
            for (int j = 0; j < _n; j++)
            {
                min_max[0] = array[i, j] < min_max[0] ? array[i, j] : min_max[0];
                min_max[1] = array[i, j] > min_max[1] ? array[i, j] : min_max[1];
            }
    }
        Debug.Log($"Size of array:{array.Length},Minimum:{min_max[0]}, Maximum:{min_max[1]}");
       
    }

 
}
