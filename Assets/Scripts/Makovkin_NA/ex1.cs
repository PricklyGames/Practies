using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    
    void Start()
    {
        string l = "Aayrt0trbAa";
        int i = 0;
        int k = 0;
        int u = 0;
        foreach(char s in l)
            if (s == 'a' || s == 'A')
            i++;        
            print(i);
        foreach(char s in l)
            k++;
            print(k);
        foreach(char s in l)
        {
        
            if (s == '0')
            {     
                print(u);
                break;
            }
            u++;
        }
        
    }

    
    void Update()
    {
        
    }
}
