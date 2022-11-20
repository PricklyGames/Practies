using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int a = 5; a <= 10; a++)
        {
            for (int b = 5; b <= 10; b++)
            {
                Debug.Log($"{a} x {b} = {a * b}");
            }    
        }
    }
}
