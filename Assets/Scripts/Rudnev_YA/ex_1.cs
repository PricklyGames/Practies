using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string stroka = "Lorem ipsum dolor sit amet, consectetur Adipiscing0 elit. Mauris gravida Aliquam ante nec luctus.";
        int count = 0, countA = 0;

        foreach (char c in stroka)
        {
            count++;

            if (c == '0')
            {
                Debug.Log($"В предложении есть символ 0, его индекс {count - 1}.");
                break;
            }

            if (c.ToString().ToLower() == "a")
            {
                countA++;
            }
        }

        Debug.Log($"В предложении {count} символов");
        Debug.Log($"В предложении {countA} символов a");

    }

}
