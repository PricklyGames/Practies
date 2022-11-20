using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const float PI = 3.14f;
        float radius = 5, krug;
        krug = PI * Mathf.Pow(2, PI);
        Debug.Log($"Ploshad' kruga = {krug}");
    }
}
