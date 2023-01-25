using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{

    
    void Start()
    {
        print("ex4");
        int lines = 3;
        int columns = 4;
      
                
        int[,] array = new int[lines, columns];
        for(int i = 0; i < array.GetLength(0); i++)
        {

            for(int j = 0; j < array.GetLength(1); j++)
            {



                print(Matrica(array[i,j])); 
            }
            print("\n");
        
                
                
        }
        int Matrica(int a)
        {
            return a;
        } 
       
     


    }

    
    void Update()
    {
        
    }
}
