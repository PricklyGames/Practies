using UnityEngine;

public class Ex1 : MonoBehaviour
{
    private string _sentence = "some Example STRING to test how0 this WIll able to accomplish its default TASK.";

    void Awake()
    {
        Debug.Log("Exercise #1. START.");

        uint length = 0;
        uint countA = 0;

        foreach (char letter in _sentence)
        {
            if (letter == '0')
            {
                Debug.Log($"The met 0 is at index: {length - 1}.");
                break;
            }

            length += 1;
            countA += (uint)(letter.ToString().ToLower() == "a" ? 1 : 0);
        }

        Debug.Log($"Counted letters A in the sentence: {countA}.");
        Debug.Log($"Length of the sentence is: {length}.");

        Debug.Log("Exercise #1. END.");
    }
}
