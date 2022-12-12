using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    private const float PI = 3.14f;
    [SerializeField] private float _radius;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EX-2");
        if (_radius > 0)
        {
            Debug.Log($"Square of circle is {PI * _radius * _radius}");
        }
        else
        {
            Debug.Log($"Radius must be larger than zero");
        }
    }


}
