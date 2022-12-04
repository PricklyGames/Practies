using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 5; i <= 10; i++)
        {
            for (int j = 5; j <= 10; j++)
            {
                Debug.Log($"{j} x {i} = {j * i}");
            }
        }
    }

    
   
}
