
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
                Debug.Log($"���� ���������� � {Length}");
                break;
            }


            if (simvol == 'a' || simvol == 'A')
            {
                countAa++;
            }
            Length++;
        }
        print($"����������� �������� 'a' � 'A' :{countAa}");
        Debug.Log($"����� ��������:{Length}");
    }
}
