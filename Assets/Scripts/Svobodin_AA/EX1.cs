using UnityEngine;

public class EX1 : MonoBehaviour
{
    string line = "asdfghjkl;plaakoi AAjuhb fnwjvbnw;AAAAijdvb;a";

    private void Start()
    {
        int countA = 0;
        int length = 0;

        foreach (char simbol in line)
        {
            if (simbol == '0')
            {
                Debug.Log($"Ноль содержится в {length}");
                break;
            }


            if (simbol == 'a' || simbol == 'A')
            { 
                countA++;
            }

            length++;
        }

        print($"Символов 'A': {countA}");
        Debug.Log($"Всего символов: {length}");
    }
}
