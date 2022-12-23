using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_3 : MonoBehaviour
{
    void Start()
    {
        Hall hall = new Hall();

        hall.FreeSeats();
        hall.Profit();
        hall.TypeOfSeat(300);

        
    }
}

public class Hall
{
    public int countSeats;
    public int occupiedSeats;
    public int costSeats;

    public Hall(int countSeats, int occupiedSeats, int costSeats) { this.countSeats = countSeats; this.occupiedSeats = occupiedSeats; this.costSeats = costSeats; }
    public Hall(int countSeats, int occupiedSeats) { this.countSeats = countSeats; this.occupiedSeats = occupiedSeats; this.costSeats = 100; }
    public Hall(int countSeats) { this.countSeats = countSeats; this.occupiedSeats = 200; this.costSeats = 1000; }
    public Hall() { this.countSeats = 750; this.occupiedSeats = 200; this.costSeats = 1000; }

    public void TypeOfSeat(int seat)
    {
        if ((seat <= countSeats * 0.2) || (seat >= countSeats * 0.85))
            Debug.Log($"Type {seat} seat: N, cost: {costSeats * 1.15}");
        else
            Debug.Log($"Type {seat} seat: M, cost: {costSeats}");
    }

    public void FreeSeats()
    {
        Debug.Log(countSeats - occupiedSeats);
    }

    public void Profit()
    {
        Debug.Log(costSeats * occupiedSeats);
    }




}
