using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_7 : MonoBehaviour
{
    public int day;

    void week(int day)
    {
        switch(day)
        {
            case 1:
                print("Monday");
                break;
            case 2:
                print("Tuesday");
                break;
            case 3:
                print("Wednesday");
                break;
            case 4:
                print("Thursday");
                break;
            case 5:
                print("Friday");
                break;
            case 6:
                print("Saturday");
                break;
            case 7:
                print("Sunday");
                break;
            default:
                print("Other value");
                break;
        }
    }

    void Start()
    {
        week(day);
    }
}
