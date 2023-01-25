using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_7 : MonoBehaviour
{
  [SerializeField] private WeekDay _day;
   private WeekDay _thisDay;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EX-7");

    }
    enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    void PrintDay(WeekDay day)
    {
        switch (day)
        {
          case  WeekDay.Monday:Debug.Log("It's Monday"); break;
            case WeekDay.Tuesday: Debug.Log("It's Tuesday"); break;
            case WeekDay.Wednesday: Debug.Log("It's Wednesday"); break;
            case WeekDay.Thursday: Debug.Log("It's Thursday"); break;
            case WeekDay.Friday: Debug.Log("It's Friday"); break;
            case WeekDay.Saturday: Debug.Log("It's Saturday"); break;
            case WeekDay.Sunday: Debug.Log("It's Sunday"); break;
        }
    }
    // Update is called once per frame
    void Update()
    {
    
        if (_day != _thisDay)
        {
            PrintDay(_day);
            _thisDay = _day;
        }
      
    }
}
