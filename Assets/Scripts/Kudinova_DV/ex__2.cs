
using UnityEngine;

public class ex__2 : MonoBehaviour
{
    private void Start()
    {
        const float p = 3.14f;
        float radius = 3;

        float sq = p * Mathf.Pow(radius, 2);

        print($"Площадь круга: {sq}");
    }
}
