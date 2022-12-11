using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_7 : MonoBehaviour
{

    public enum DayWeek
    { 
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public DayWeek dayWeek;

    // Start is called before the first frame update
    void Start()
    {
        PrintDay(dayWeek);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        PrintDay(dayWeek);
    }

    void PrintDay(DayWeek dayWeek)
    {
        switch (dayWeek)
        {
            case DayWeek.Monday:
                Debug.Log("Selected Monday!");
                break;

            case DayWeek.Wednesday:
                Debug.Log("Selected Wednesday!");
                break;

            case DayWeek.Tuesday:
                Debug.Log("Selected Tuesday!");
                break;

            case DayWeek.Thursday:
                Debug.Log("Selected Thursday!");
                break;

            case DayWeek.Friday:
                Debug.Log("Selected Friday!");
                break;

            case DayWeek.Saturday:
                Debug.Log("Selected Saturday!");
                break;

            case DayWeek.Sunday:
                Debug.Log("Selected Sunday!");
                break;
        }
    }
}
