using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{

    void Start()
    {
        print("ex3");
        int[][] array = 
        {
            new int[] {1, 3, 4},
            new int[] {4, 7, 8},
            new int[] {2, 9, 0}
        };
        int[][] array1 = 
        {
            new int[] {1, 0, 1, 1},
            new int[] {0, 1, 1},
            new int[] {0, 1, 0, 0}
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
        string f = "Элемент найден";
        for(int i = 0; i < array1.Length; i++)
        {
            for(int j = 0; j < array1[i].Length; j++)
            {


                
                if(array1[i][j] == 1)
                {
                    print(Found(f,i,j));
                    


                }
                     

            }
        }
        string Found(string f, int i, int j)
        {                        
            return $"{f},{i},{j}";
        }

        print(Massiv(Min, Max, t));

        string Massiv(int Min, int Max, int t)
        {

            return $"{Min},{Max},{t}";
        }

        
        
    }

    void Update()
    {
        

        
     
        
        

        
   
        
    }
}
