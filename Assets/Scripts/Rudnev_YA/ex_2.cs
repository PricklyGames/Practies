using UnityEngine;

public class ex_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const float PI = 3.14f;

        float square, radius = 5f;

        square = PI * Mathf.Pow(radius, 2);

        Debug.Log("The beginning of the second task");
        Debug.Log($"The area of the circle is equal to {square}");
        Debug.Log("End of the second task");
    }

}