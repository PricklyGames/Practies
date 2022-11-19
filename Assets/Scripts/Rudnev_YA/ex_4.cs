using UnityEngine;

public class ex_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The beginning of the fourth task");

        for (int i = 5; i <= 10; i++)
        {
            for (int j = 5; j <= 10; j++)
            {
                Debug.Log($"{j} x {i} = {j * i}");
            }
        }

        Debug.Log("End of the fourth task");
    }
}
