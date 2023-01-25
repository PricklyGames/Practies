using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex7 : MonoBehaviour
{
    public enum day
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    public day Day; 
    day DayTemp;
    void PrintDay(day Day)
    {
        switch(Day)
        {
            case day.Monday:
                Debug.Log("Monday");
                break;
            case day.Tuesday:
                Debug.Log("Tuesday");
                break;
            case day.Wednesday:
                Debug.Log("Wednesday");
                break;
            case day.Thursday:
                Debug.Log("Thursday");
                break;
            case day.Friday:
                Debug.Log("Friday");
                break;
            case day.Saturday:
                Debug.Log("Saturday");
                break;
            case day.Sunday:
                Debug.Log("Sunday");
                break;


        }
    }

    void Update()
    {
        if (DayTemp != Day)
        {
            DayTemp = Day;
            PrintDay(DayTemp);
        }
    }
    void Start()
    {
        PrintDay(Day);
        DayTemp = Day;
    }
    
}