using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_6 : MonoBehaviour
{

    public int count;

    // Start is called before the first frame update
    void Start()
    {

        int number1, number2;

        RandNum(count, out number1);
        RandNumRef(ref count, out number2);

        Debug.Log(number1);
        Debug.Log(number2);

        // Methods

        void RandNum (int count, out int number)
        {
            number = Random.Range(0, count);
        }

        void RandNumRef(ref int count, out int number)
        {
            number = Random.Range(0, count);
        }

    }

}
