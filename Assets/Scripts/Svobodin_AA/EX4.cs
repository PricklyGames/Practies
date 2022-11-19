using UnityEngine;

public class EX4 : MonoBehaviour
{
    private void Start()
    {
        for (int i = 5; i <= 10; i++)
        {
            string result = "";

            for (int j = 5; j <= 10; j++)
            {
                result += $"{i}x{j}={i * j} \n";
            }

            print(result);
        }
    }
}
