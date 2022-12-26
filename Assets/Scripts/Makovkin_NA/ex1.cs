using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour 
{
    
    void Start()
    {
        print("ex1");
        int[][] array = 
        {
            new int[] {1, 3, 4},
            new int[] {4, 7, 8},
            new int[] {2, 9, 0}
        };
        int Min = array[0][0];   
        for(int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < array[i].Length; j++)
            {
                if (array[i][j] < Min)
                Min = array[i][j];
            }
        }
        int Max = array[0][0];
        int t = 0;
        for(int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < array[i].Length; j++)
            {
                if (array[i][j] > Max)
                Max = array[i][j];
                t++;
    
            }
        }
    
            
        
        print($"{Min},{Max},{t}");

    }
        

                
                
                

           

        
       

    
    void Update()
    {
        
    }
}
