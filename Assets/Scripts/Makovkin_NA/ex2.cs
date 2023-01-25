using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour 
{
    
    void Start()
    {
        print("ex2");
        int[][] array = 
        {
            new int[] {1, 0, 1, 1},
            new int[] {0, 1, 1},
            new int[] {0, 1, 0, 0}
        };
        for(int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < array[i].Length; j++)
            {
              if(array[i][j] == 1)
              print($"Элемент найден [{i}],[{j}]");
            }
        }
     
        
        
    }

    
    void Update()
    {
        
    }
}
    

        
    

    
    

