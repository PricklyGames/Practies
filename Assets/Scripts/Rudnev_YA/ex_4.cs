using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The beginning of the fourth task");

        for (int i = 5; i <= 10; i++)
        {
            Debug.Log($"{i} x 5 = {i * 5}");
        }

        Debug.Log("End of the fourth task");
    }
}
