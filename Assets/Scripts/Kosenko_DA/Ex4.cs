using UnityEngine;

public class Ex4 : MonoBehaviour
{
    public const byte StartNumber = 5;

    void Awake()
    {
        Debug.Log("Exercise #4. START.");

        for (byte i = StartNumber; i <= 10; i++)
        {
            Debug.Log($"{i}x{StartNumber}={i * StartNumber}");
        }

        Debug.Log("Exercise #4. END.");
    }
}
