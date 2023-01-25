using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PracticeOne;
using PracticeTwo;

public class ex_1 : MonoBehaviour
{

    public int prTwoExOneN;
    public int prTwoExTwoN;
    public int prTwoExThreeNOne;
    public int prTwoExThreeNTwo;
    public int prTwoExFourRow;
    public int prTwoExFourColumn;
    public int prTwoExFiveRow;
    public int prTwoExSixCount;

    public DayWeek prTwoExSevenDayWeek;
    DayWeek prTwoExSevenDayWeekTmp;

    // Start is called before the first frame update
    void Start()
    {
        PrOne practiceOne = new();

        practiceOne.PrintBeginPr();

        practiceOne.exOneStr = "Lorem ipsum dolor sit amet, consectetur Adipiscing0 elit. Mauris gravida Aliquam ante nec luctus.";
        practiceOne.ExOne(practiceOne.exOneStr);

        practiceOne.exTwoRadius = 5f;
        practiceOne.ExTwo(practiceOne.exTwoRadius);

        practiceOne.exThreeSetSquareRectangle = 25f;
        practiceOne.exThreeLength = 7f;
        practiceOne.exThreeWidth = 10f;
        practiceOne.ExThree(practiceOne.exThreeSetSquareRectangle, practiceOne.exThreeLength, practiceOne.exThreeWidth);

        practiceOne.ExFour();

        practiceOne.PrintEndPr();

        PrTwo practiceTwo = new() { exOneSizeMas = prTwoExOneN, exTwoSizeMas = prTwoExTwoN, exThreeSizeMasOne = prTwoExThreeNOne, exThreeSizeMasTwo = prTwoExThreeNTwo, exFourRow = prTwoExFourRow, exFourColumn = prTwoExFourColumn, exFiveRow = prTwoExFiveRow, exSixCount = prTwoExSixCount, dayWeek = prTwoExSevenDayWeek };

        practiceTwo.PrintBeginPr();

        practiceTwo.ExOne(practiceTwo.exOneSizeMas);

        practiceTwo.ExTwo(practiceTwo.exTwoSizeMas);

        practiceTwo.ExThree(practiceTwo.exThreeSizeMasOne, practiceTwo.exThreeSizeMasTwo);

        practiceTwo.ExFour(practiceTwo.exFourRow, practiceTwo.exFourColumn);

        practiceTwo.ExFive(practiceTwo.exFiveRow);

        practiceTwo.ExSix(practiceTwo.exSixCount);

        practiceTwo.PrintEndPr();

        practiceTwo.PrintDay(practiceTwo.dayWeek);

        prTwoExSevenDayWeekTmp = prTwoExSevenDayWeek;
    }

    void Update()
    {
        PrTwo practiceTwo = new() { dayWeek = prTwoExSevenDayWeek };

        if (prTwoExSevenDayWeekTmp != practiceTwo.dayWeek)
        {
            prTwoExSevenDayWeekTmp = practiceTwo.dayWeek;
            practiceTwo.PrintDay(prTwoExSevenDayWeekTmp);
        }
    }
}

namespace PracticeOne
{
    class PrOne
    {
        public string exOneStr;
        public float exTwoRadius;
        public float exThreeSetSquareRectangle, exThreeLength, exThreeWidth;

        public void ExOne(string str)
        {
            int count = 0, countA = 0;

            Debug.Log("The beginning of the first task");

            foreach (char c in str)
            {
                count++;

                if (c == '0')
                {
                    Debug.Log($"The sentence has the symbol 0, its index {count - 1}.");
                    break;
                }

                if (c == 'a' || c == 'A')
                {
                    countA++;
                }
            }

            Debug.Log($"In the sentence {count} characters!");
            Debug.Log($"In the sentence {countA} characters a!");

            Debug.Log("End of the first task");
        }

        public void ExTwo(float radius)
        {
            const float PI = 3.14f;
            float square;

            square = PI * Mathf.Pow(radius, 2);

            Debug.Log("The beginning of the second task");
            Debug.Log($"The area of the circle is equal to {square}");
            Debug.Log("End of the second task");

        }

        public void ExThree(float setSquareRectangle, float length, float width)
        {
            float squareRectangle = length * width;

            Debug.Log("The beginning of the third task");
            Debug.Log($"Rectangle area: {squareRectangle}");

            if (squareRectangle > setSquareRectangle)
            {
                Debug.Log($"The specified area of the rectangle: {setSquareRectangle}");
                Debug.Log($"The found area of the rectangle is larger than the one specified {squareRectangle - setSquareRectangle}");
            }

            Debug.Log("End of the third task");
        }

        public void ExFour()
        {
            Debug.Log("The beginning of the fourth task");

            for (int i = 5; i <= 10; i++)
            {
                for (int j = 5; j <= 10; j++)
                {
                    Debug.Log($"{j} x {i} = {j * i}");
                }
            }

            Debug.Log("End of the fourth task");
        }

        public void PrintBeginPr()
        {
            Debug.Log("The beginning of the first practice!");
        }

        public void PrintEndPr()
        {
            Debug.Log("End of the first practice!");
        }
    }
}

namespace PracticeTwo
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

    class PrTwo
    {
        public int exOneSizeMas;
        public int exTwoSizeMas;
        public int exThreeSizeMasOne;
        public int exThreeSizeMasTwo;
        public int exFourRow;
        public int exFourColumn;
        public int exFiveRow;
        public int exSixCount;

        public DayWeek dayWeek;

        public void ExOne(int n)
        {
            int[,] mas = new int[n, n];
            int[] minMaxEl = new int[2] { 255, -1 };

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = Random.Range(0, 126);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (minMaxEl[0] > mas[i, j])
                    {
                        minMaxEl[0] = mas[i, j];
                    }

                    if (minMaxEl[1] < mas[i, j])
                    {
                        minMaxEl[1] = mas[i, j];
                    }
                }
            }

            Debug.Log("The beginning of the first task");

            Debug.Log($"Number of elements of the original array: {mas.Length}. Minimum element {minMaxEl[0]}. Maximum element {minMaxEl[1]}.");

            Debug.Log("End of the first task");
        }

        public void ExTwo(int n)
        {
            int[][] mas = new int[n][];

            for (int i = 0; i < n; i++)
            {
                mas[i] = new int[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i][j] = Random.Range(0, 2);
                }
            }

            Debug.Log("The beginning of the second task");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mas[i][j] == 1)
                    {
                        Debug.Log($"An element equal to one is found, its index is {i} {j}.");
                    }
                }
            }

            Debug.Log("End of the second task");
        }

        public void ExThree(int sizeMasOne, int sizeMasTwo)
        {

            Debug.Log("The beginning of the third task");

            // First task
            int[,] mas_1 = new int[sizeMasOne, sizeMasOne];
            int[] minAndMaxEl = new int[2] { 255, -1 };

            for (int i = 0; i < sizeMasOne; i++)
            {
                for (int j = 0; j < sizeMasOne; j++)
                {
                    mas_1[i, j] = Random.Range(0, 125);
                }
            }

            Ex1(mas_1, ref minAndMaxEl);
            Debug.Log($"Number of elements of the original array: {mas_1.Length}. Minimum element {minAndMaxEl[0]}. Maximum element {minAndMaxEl[1]}.");

            // Second task
            int[][] mas_2 = new int[sizeMasTwo][];

            for (int i = 0; i < sizeMasTwo; i++)
            {
                mas_2[i] = new int[sizeMasTwo];
            }

            for (int i = 0; i < sizeMasTwo; i++)
            {
                for (int j = 0; j < sizeMasTwo; j++)
                {
                    mas_2[i][j] = Random.Range(0, 2);
                }
            }

            Ex2(mas_2);

            Debug.Log("End of the third task");
        }

        public void ExFour(int row, int column)
        {
            Debug.Log("The beginning of the fourth task");

            int[,] mas = CreateMas(row, column);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Debug.Log(mas[i, j]);
                }
            }

            Debug.Log("End of the fourth task");
        }

        public void ExFive(int row)
        {
            Debug.Log("The beginning of the fifth task");

            int[][] mas = CreateMas2(row);

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    Debug.Log(mas[i][j]);
                }
            }

            Debug.Log("End of the fifth task");
        }

        public void ExSix(int count)
        {
            Debug.Log("The beginning of the sixth task");

            int number1, number2;

            RandNum(count, out number1);
            RandNumRef(ref count, out number2);

            Debug.Log(number1);
            Debug.Log(number2);

            Debug.Log("End of the sixth task");
        }

        public void PrintBeginPr()
        {
            Debug.Log("The beginning of the second practice!");
        }

        public void PrintEndPr()
        {
            Debug.Log("End of the second practice!");
        }

        void Ex1(int[,] mas, ref int[] minAndMaxEl)
        {

            for (int i = 0; i < exThreeSizeMasOne; i++)
            {
                for (int j = 0; j < exThreeSizeMasOne; j++)
                {
                    if (minAndMaxEl[0] > mas[i, j])
                    {
                        minAndMaxEl[0] = mas[i, j];
                    }

                    if (minAndMaxEl[1] < mas[i, j])
                    {
                        minAndMaxEl[1] = mas[i, j];
                    }
                }
            }

        }

        void Ex2(int[][] mas)
        {
            for (int i = 0; i < exThreeSizeMasTwo; i++)
            {
                for (int j = 0; j < exThreeSizeMasTwo; j++)
                {
                    if (mas[i][j] == 1)
                    {
                        Debug.Log($"An element equal to one is found, its index is {i} {j}.");
                    }
                }
            }
        }

        int[,] CreateMas(int row, int column)
        {
            int[,] mas = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    mas[i, j] = Random.Range(0, 126);
                }
            }

            return mas;
        }

        int[][] CreateMas2(int row = 5)
        {
            int[][] mas = new int[row][];

            for (int i = 0; i < row; i++)
            {
                mas[i] = new int[Random.Range(1, 10)];
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    mas[i][j] = Random.Range(0, 126);
                }
            }

            return mas;
        }

        void RandNum(int count, out int number)
        {
            number = Random.Range(0, count);
        }

        void RandNumRef(ref int count, out int number)
        {
            number = Random.Range(0, count);
        }

        public void PrintDay(DayWeek dayWeek)
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
}
