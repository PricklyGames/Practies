
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
            print($" Площадь = {sq}, начальная: {necessq}, разница: {necessq - sq}");
        }

        else
        {
            print("Расчитанная площадь меньше");
        }
    }
}
