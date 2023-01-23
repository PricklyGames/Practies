using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { 
      Debug.Log("EX-6");
        int number=0;
        RandomRef(ref number);
        Debug.Log($"Number in method in start after ref {number}");
        RandomValue(number);
        Debug.Log($"Number in method in start after value {number}");
    }
    void RandomValue(int number)
    {
        number = Random.Range(1, 100);
        Debug.Log($"Number in method with value {number}");
    }
    void RandomRef(ref int number)
    {
        number = Random.Range(1, 100);
        Debug.Log($"Number in method with reference {number}");
    }
}
