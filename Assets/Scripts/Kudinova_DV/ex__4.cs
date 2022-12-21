using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex__4 : MonoBehaviour
{
    private void Start()
    {
        for (int i = 5; i <= 10; i++)
        {
            string resultat = "";

            for (int j = 5; j <= 10; j++)
            {
                resultat += $"{i}x{j}={i * j} \n";
            }
            print(resultat);
        }
    }

}
