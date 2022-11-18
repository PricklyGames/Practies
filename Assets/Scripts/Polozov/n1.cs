using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class n1 : MonoBehaviour
{
    [SerializeField] string String;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("N1:");
        int Lenght = 0, Acounter = 0;
        foreach (char chr in String)
        {
            Lenght++;
            if (chr.ToString().ToLower() == "a")
            {
                Acounter++;
            }
            if (chr == '0')
            {
                Debug.Log($"0 in :{Lenght}");
                break;
            }
        }
        Debug.Log($"count of a:{Acounter}");
        Debug.Log($"length of string:{Lenght}");

    }


}
