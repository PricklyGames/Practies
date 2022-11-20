using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int Acounter = 0;
        int Bcounter = 0;
        string line = "Ebychaya zalypa nahui,pishy 0vtoroi raz,ya v shoke";
        foreach (char line1 in line)
        {
            if (line1 == '0')
            {
                Debug.Log(Bcounter);
                return;
            }
            if (line1 == 'a' || line1 == 'A')
            {
                Acounter++;
            }
            Bcounter++;
        }
        Debug.Log($"bukva a = {Acounter} and kol-vo bukv v nabore {Bcounter}");
    }
}

