using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10, b = 5, ploshad,ploshadzadannaya = 40, raznica;
        ploshad = a * b;
        if (ploshadzadannaya < ploshad)
        {
            raznica = ploshad - ploshadzadannaya;
            Debug.Log($"Zadannaya ploshad = {ploshadzadannaya}, rashitannaya ploshad = {ploshad}, raznica ploshadey = {raznica}");
        }
        if (ploshadzadannaya>ploshad)
        {
            Debug.Log("Zadannaya ploshad bolshe chem vyshitannaya");
        }
    }
}
