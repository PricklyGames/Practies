using UnityEngine;

public class EX2 : MonoBehaviour
{
    private void Start()
    {
        const float p = 3.14f;
        float radius = 10;

        float sq = p * Mathf.Pow(radius, 2);

        print($"Площадь = {sq}");
    }
}
