using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_3 : MonoBehaviour
{
    void Start()
    {
        Hall hall = new();

        hall.FreeSeats();
        hall.Profit();
    }

    
}

public class Hall
{
    public int count, occupiedSeats, cost;
    public float coefficient_N, coefficient_M;

    public Hall(int count = 500, int occupiedSeats = 300, int cost = 1000, float coefficient_N = 1.15f, float coefficient_M = 1f)
    {
        this.count = count;
        this.occupiedSeats = occupiedSeats;
        this.cost = cost;
        this.coefficient_N = coefficient_N;
        this.coefficient_M = coefficient_M;
    }

    public void FreeSeats()
    {
        Debug.Log($"Number of available seats {count - occupiedSeats}");
    }

    public void Profit()
    {
        float profit = 0;

        int[] hall = CreateArray();

        for (int i = 0; i < this.count; i++)
        {
            if (hall[i] == 1)
            {
                if (i < this.count * 0.2 || i > this.count * 0.85)
                    profit += cost * coefficient_N;
                else
                    profit += cost * coefficient_M;
            }
        }

        Debug.Log($"Profit from the sale {profit}");
    }

    public int[] CreateArray()
    {
        int[] array = new int[this.count];
        int countOccupiedSeats = 0;

        while(countOccupiedSeats < occupiedSeats)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (countOccupiedSeats < occupiedSeats)
                {
                    if (array[i] == 0)
                    {
                        array[i] = Random.Range(0, 2);

                        if (array[i] == 1)
                        {
                            countOccupiedSeats++;
                        }
                    }  
                }
                else
                    break;
            }
        }

        /*
        foreach (int i in array)
            Debug.Log(i);
        Debug.Log($"countOccupiedSeats {countOccupiedSeats}");
        */

        return array;
    }




}

