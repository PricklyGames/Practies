using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Point point1 = new() { x = 5, y = 2, z = 3};
        Point point2 = new() { x = 3, y = 4, z = 5 };
        Debug.Log($"Distance between points: {point1.CalcDist(point2)}");
        point1.ZeroPoint();
        point2.OffsetPoint();
        Debug.Log($"{point1.x}, {point1.y}, {point1.z}");
        Debug.Log($"{point2.x}, {point2.y}, {point2.z}");
    }
}

struct Point
{
    public int x, y, z;

    public float CalcDist(Point point)
    {
        float dist = Mathf.Sqrt(Mathf.Pow((point.x - x), 2) + Mathf.Pow((point.y - y), 2) + Mathf.Pow((point.z - z), 2));
        return dist;
    }

    public void ZeroPoint()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    public void OffsetPoint()
    {
        x += Random.Range(-10, 11);
        y += Random.Range(-10, 11);
        z += Random.Range(-10, 11);
    }
}
