
using UnityEngine;

public class Exe1 : MonoBehaviour
{
    string line = "ajdfajAdjhfAahhAj;aj 0 ;aknkjfbAAnjj";

    private void Start()
    {
        int countAa = 0;
        int Length = 0;

        foreach (char simvol in line)
        {
            if (simvol == '0')
            {
                Debug.Log($"Ноль содержится в {Length}");
                break;
            }


            if (simvol == 'a' || simvol == 'A')
            {
                countAa++;
            }
            Length++;
        }
        print($"Колличество символов 'a' и 'A' :{countAa}");
        Debug.Log($"Всего символов:{Length}");
    }
}
