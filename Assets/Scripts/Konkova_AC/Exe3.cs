
using UnityEngine;

public class Exe3 : MonoBehaviour
{
    private void Start()
    {
        float necessq = 20;
        float len = 5;
        float width = 9;
        float sq = len * width;
        if (sq > necessq)
        {
            print($" ������� = {sq}, ���������: {necessq}, �������: {necessq - sq}");
        }

        else
        {
            print("����������� ������� ������");
        }
    }
}
