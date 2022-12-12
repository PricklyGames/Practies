using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EX-4");
        for (int i = 5; i <= 10; i++)
            for (int j = 5; j <= 10; j++)
                Debug.Log($"{j}*{i}={i * j}");
    }

    // Update is called once per frame

}
