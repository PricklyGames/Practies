using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_4 : MonoBehaviour
{
    void Start()
    {
        Point point_1 = new() { x = 2, y = 1, z = 3 };
        Point point_2 = new() { x = 5, y = 3, z = 1 };

        point_1.Distance(point_2);

        point_1.RandomPoint();
        point_1.PrintPoint();

        point_1.ZeroingPoint();
        point_1.PrintPoint();

    }

    
}

struct Point
{
    public int x, y, z;

    public void Distance(Point point)
    {
        float distance = Mathf.Sqrt(Mathf.Pow(point.x - x, 2) + Mathf.Pow(point.y - y, 2) + Mathf.Pow(point.z - z, 2));

        Debug.Log($"The distance between the points is equal to {distance}");
    }

    public void ZeroingPoint() { x = 0; y = 0; z = 0; }

    public void RandomPoint() { x = Random.Range(-10, 11); y = Random.Range(-10, 11); z = Random.Range(-10, 11); }

    public void PrintPoint() { Debug.Log($"x = {x}, y = {y}, z = {z}"); }
}
