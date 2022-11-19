using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float set_square_rectangle = 25.0f, length = 7f, width = 10f, square_rectangle;
        square_rectangle = length * width;

        Debug.Log("The beginning of the third task");
        Debug.Log($"Rectangle area: {square_rectangle}");

        if (square_rectangle > set_square_rectangle)
        {
            Debug.Log($"The area of the rectangle is less than the one specified by {square_rectangle - set_square_rectangle}");
        }

        Debug.Log("End of the third task");

    }

}
