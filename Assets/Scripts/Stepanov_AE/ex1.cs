using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {


        string str = "Андрей автомобиль машина карета Ананас Апельсин";

        int n = 0; // Буквы а,А

        int ks = 0; // Количество символов

        foreach (char c in str)
        {
            ks++;

            if (c.ToString().ToLower() == "а")
            {
                n++;
            }
            
        }

        Debug.Log("Количество букв А,а=" + n);
        Debug.Log("Количество букв = " + ks);
    }
}




