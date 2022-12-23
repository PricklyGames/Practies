
using UnityEngine;

public class Exe2 : MonoBehaviour
{
    private void Start()
    {
        const float pi = 3.14f;
        float rad = 5;
        float sq = pi * Mathf.Pow(rad, 2);

        print($" Площадь круга = {sq}");
    }
}
