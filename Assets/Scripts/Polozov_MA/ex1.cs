using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    [SerializeField] private string _myString;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EX-1");

        int i,_aCounter = 0;
        for(i = 0; i < _myString.Length; i++)
        {
            if (_myString[i] == 'A' || _myString[i] == 'a')
            {
                _aCounter++;
            }
            if (_myString[i] == '0')
            {
                break;
            }
        }
        if (i == _myString.Length) {
            Debug.Log($"Amount of A {_aCounter}, amount of symbols in sentence {i}");
                }
        else
        {
            Debug.Log($"Amount of A {_aCounter}, amount of symbols in sentence {i}, position of 0 is {i+1}");
        }
    }

    // Update is called once per frame
}
