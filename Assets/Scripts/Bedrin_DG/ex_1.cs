using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_1 : MonoBehaviour
{
    void Start()
    {
        int score_1;
        score_1 = 0;
        int score_2;
        score_2 = 0;
        string sentence;
        sentence = ("aaAjgaAAkaAajhaAsjhGSAkda0sdjhsda");
        foreach (var c in sentence)
        {
            if (c == '0')
                break;
            score_2 += 1;
            if (c == 'a' || c == 'A')
                score_1 += 1;
        }
        Debug.Log($"Букв 'а' в этом предложении {score_1}");
        Debug.Log($"В этом предложении {score_2} букв");
    }
}
