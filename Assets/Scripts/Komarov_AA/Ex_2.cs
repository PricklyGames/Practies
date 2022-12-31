using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Space_1;
using Space_2;

public class Ex_2 : MonoBehaviour
{
    void Start()
    {
        Practices_1 practices_1 = new();
        Practices_2 practices_2 = new();

        Ex ex = new(practices_1, practices_2);

        ex.GetPractices_1();
        ex.GetPractices_2();
    }

}

class Ex
{
    public Practices_1 practices_1;
    public Practices_2 practices_2;

    public Ex(Practices_1 practices_1, Practices_2 practices_2)
    {
        this.practices_1 = practices_1;
        this.practices_2 = practices_2;
    }

    public void GetPractices_1()
    {
        Debug.Log("Practice_1:");

        Debug.Log("Ex_1");
        practices_1.CheckingCharacters("AfdfaaAdsa0Adadf");

        Debug.Log("Ex_2");
        practices_1.GetSquareCircle(5);

        Debug.Log("Ex_3");
        practices_1.GetSquareRectangle(7, 5, 20);

        Debug.Log("Ex_4");
        practices_1.GetMultiplicationTable();
    }

    public void GetPractices_2()
    {
        Debug.Log("Practice_2:");

        Debug.Log("Ex_1");

        int n = Random.Range(1, 10);
        int[,] array1 = new int[n, n];

        practices_2.GetMaxMinArray(array1);

        Debug.Log("Ex_2");

        n = Random.Range(1, 10);
        int[][] array2 = new int[n][];

        practices_2.GetJaggedArray(array2);

        Debug.Log("Ex_3");

        n = Random.Range(1, 10);
        practices_2.Ex_3(n);

        Debug.Log("Ex_4");

        practices_2.PrintArray(practices_2.GetTwoDimensonalArray(3, 5));

        Debug.Log("Ex_5");

        practices_2.PrintArray(practices_2.GetRandomColumnsJaggedArray(5));

        Debug.Log("Ex_6");

        practices_2.Ex_6();

        Debug.Log("Ex_7");

        practices_2.Week(3);
    }


}
