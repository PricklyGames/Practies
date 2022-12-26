using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex6 : MonoBehaviour
{
    
    void Start()
    {
        print("ex6");
        F("ex6", 3);
        void F(string value, int number)
        {
            int num;
            int num1;
            Ref(36,52, out num, out num1);
        
            

        }
        void Ref(int x ,int y, out int number,out int number1)
        {
            number = 3 * (y & 6) + (y>> 16);
            number1 = 2 *(x & 6) + (x>> 16);
            y = (int)((number << 16) + number1);
            print(y);



        
        }
        
        
     
        
       
        
    }

    
    void Update()
    {
        
    }
}
