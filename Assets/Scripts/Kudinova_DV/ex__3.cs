using UnityEngine;

public class ex__3 : MonoBehaviour
{
    private void Start()
    {
        float width = 20;
        float height = 5;

        float targetSq = 20;

        float currentSq = width + height;

        if (currentSq > targetSq)
        {
            print($"Расчитанная: {currentSq}, Требуемая: {targetSq}, Разница: {targetSq - currentSq}");
        }
        else
        {
            print($"Расчитанная площадь меньше");
        }
    }
}
