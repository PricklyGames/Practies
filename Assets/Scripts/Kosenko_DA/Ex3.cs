using UnityEngine;

public class Ex3 : MonoBehaviour
{
    private float _width = 3f;
    private float _length = 5f;

    private float _forecastedArea = 14f;

    void Awake()
    {
        Debug.Log("Exercise #3. START.");

        float calculatedArea = _width * _length;

        if (calculatedArea > _forecastedArea)
        {
            Debug.Log($"The forecasted area is {_forecastedArea}.");
            Debug.Log($"The calculated area is {calculatedArea}.");
            Debug.Log($"The difference between them is {calculatedArea - _forecastedArea}.");
        }

        Debug.Log("Exercise #3. END.");
    }
}
