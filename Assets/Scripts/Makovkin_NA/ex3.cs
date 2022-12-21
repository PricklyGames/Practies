using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
    
    void Start()
    {
        int a = 4;
        int b = 5;
        int S1 = 16;
        int S2 = a * b;
        int raznica = S2 - S1;
        if (S2 > S1)
        {
            print(S2);
        }

        {
            print(raznica);
        }
        
    }

    
    void Update()
    {
        
    }
}
