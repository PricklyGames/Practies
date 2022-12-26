using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{
    
    private void Start()
    {
        print("ex5");
    
        F("ex5", 3);
        void F(string value, int number)
        {
            GG1(number, 3);

        }
   
        void GG1(int a ,int t = 5)
        {

            int[][] array =
            {
                new int [4],
                new int [3],
                new int [2],
                new int [5],
                new int [4],
                new int [5],
                new int [3],
            };
            for (int i = 0; i < array[t-2].Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    a = array[i][j];
                    print($"{a}");
                }
                print("\n");
        
            }
            
        
        }
            
        
        

        
    }

    
    void Update()
    {
        
    }
}
