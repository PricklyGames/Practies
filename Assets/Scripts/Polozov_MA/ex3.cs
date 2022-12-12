using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
 [SerializeField] private float _width;
 [SerializeField] private float _heitgh;
 [SerializeField] private float _givenSquare;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EX-3");
        float _foundSquare = _width * _heitgh;
        if (_foundSquare> _givenSquare)
        {
            Debug.Log($"Given square:{_givenSquare}, Found Square:{_foundSquare}, Difference:{_foundSquare-_givenSquare}");
        }
        else
        {
            Debug.Log("Given square is equal or larger than Found square");
        }
    }

}
