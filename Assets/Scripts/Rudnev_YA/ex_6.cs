using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_6 : MonoBehaviour
{

    public int count;

    // Start is called before the first frame update
    void Start()
    {

        int number;

        RandNum(in count, out number);

        Debug.Log(number);

        // Method

        void RandNum (in int count, out int number)
        {
            number = Random.Range(0, count);
        }

    }

}
