using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Hall hall = new(9, 10, 65, 320);
        int freeSeats = hall.NumFreeSeats();
        float fullAmount = hall.CostCalc();

        Debug.Log($"Number of available seats: {freeSeats}.");
        Debug.Log($"Total cost of purchased tickets: {fullAmount}rub.");
    }
}

class Hall
{
    int numRows, numSeatsInRow, numBuySeats, price;
    float M, N;
    float allCost;

    int[,] masHall;

    public Hall(int numRows, int numSeatsInRow, int numBuySeats, int price)
    {
        this.numRows = numRows;
        this.numSeatsInRow = numSeatsInRow;
        this.numBuySeats = numBuySeats;
        this.price = price;

        M = 1;
        N = 1.2f;
        allCost = 0;

        masHall = CreateMas(numRows, numSeatsInRow);
    }

    public int NumFreeSeats()
    {
        int numFreeSeats = numRows * numSeatsInRow - numBuySeats;

        return numFreeSeats;
    }

    public float CostCalc()
    {
        int indBegRow, indBegCol, indEndRow, indEndCol;

        float countBeg = numRows * numSeatsInRow * 0.2f;

        indBegRow = (int)countBeg / numSeatsInRow;
        indBegCol = (int)countBeg % numSeatsInRow;

        float countEnd = numRows * numSeatsInRow * 0.85f;

        countEnd = (int)Mathf.Round(countEnd);

        indEndRow = (int)countEnd / numSeatsInRow;
        indEndCol = (int)countEnd % numSeatsInRow;

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numSeatsInRow; j++)
            {
                if ((i < indBegRow && j < numSeatsInRow) || (i == indBegRow && countBeg % numSeatsInRow != 0 && j < indBegCol) || (i == indEndRow && j >= indEndCol) || (i > indEndRow && j < numSeatsInRow))
                {
                    allCost += (masHall[i, j] * N * price);
                }
                else
                {
                    allCost += (masHall[i, j] * M * price);
                }
                
            }
        }

        return allCost;
    }

    int[,] CreateMas(int row, int column)
    {
        int[,] mas = new int[row, column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                mas[i, j] = 0;
            }
        }

        int count = 0;

        while (count < numBuySeats)
        {
            int i = Random.Range(0, row);
            int j = Random.Range(0, column);

            if (mas[i, j] == 0)
            {
                mas[i, j] = 1;
                count++;
            }
        }

        return mas;
    }

}