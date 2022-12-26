using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex7 : MonoBehaviour
{
    
    void Start()
    {
        print("ex7");
        F("ex7", 3);
        void F(string value, int number)
        {
            print(Week("Воскресенье"));
           
        
            

        }
        string Week(string line)
        {
            switch(line)
            {
                case "Понедельник": return "Понедельник";
                case "Вторник": return "Вторник";
                case "Среда": return "Среда";
                case "Четверг": return "Четверг";
                case "Пятница": return "Пятница";
                case "Суббота": return "Суббота";
                case "Воскресенье": return "Воскресенье";

                default: return "Not Found";

            }
        }
        
    }

    
    void Update()
    {
        
    }
}
