using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Space_1;
using Space_2;

public class Ex_1 : MonoBehaviour
{
    void Start()
    {
        //CheckingCharacters("AfdfaaAdsa0Adadf");
        //CreateSquareCircle(5);
        //CreateSquareRectangle(7, 5);
        //GetMultiplicationTable();

        Practices_1 practices_1 = new Practices_1();
        //practices_1.GetSquareCircle(4);

        Practices_2 practices_2 = new Practices_2();
        //practices_2.Ex_3(5);
        //practices_2.PrintArray(practices_2.GetTwoDimensonalArray(3, 5));
        //practices_2.PrintArray(practices_2.GetRandomColumnsJaggedArray(5));
        //practices_2.Ex_6();
        practices_2.Week(3);
    }
}

namespace Space_1
{
    class Practices_1
    {
        public void CheckingCharacters(string line)
        {
            //string line = "AfdfaaAdsa0Adadf";
            int countA = 0, length = 0;
            foreach (char c in line)
            {
                if (c == '0')
                {
                    Debug.Log($"The line has '0', index {length}");
                    break;
                }
                if (c == 'A' || c == 'a')
                    countA++;
                length++;
            }
            Debug.Log($"Number of characters a = {countA}, Line length = {length}");
        }

        public void GetSquareCircle(float r)
        {
            const float PI = 3.14f;
            //float r = 5;
            float square = PI * r * r;
            Debug.Log($"The area of the circle is equal to {square}");
        }

        public void GetSquareRectangle(float height, float width, float main_square = 20)
        {
            //float height = 7, width = 5, main_square = 20;
            float square = height * width;
            if (square > main_square)
            {
                Debug.Log($"The area found is equal to {square}");
                Debug.Log($"The found are is larger than the one specified on {square - main_square}");
            }
        }

        public void GetMultiplicationTable()
        {
            for (int i = 5; i <= 10; i++)
                Debug.Log($"{i} x 5 = {i * 5}");
        }
    }
}

namespace Space_2
{
    class Practices_2
    {
        public int[] GetMaxMinArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = Random.Range(-50, 51);
            }

            int min = array[0, 0], max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                        min = array[i, j];
                    if (array[i, j] > max)
                        max = array[i, j];
                }
            }

            int[] numbers = { min, max };

            Debug.Log("Number of array elements " + array.Length);

            Debug.Log("Minimum and maximum array element:\n");

            foreach (int c in numbers)
                Debug.Log(c);

            return numbers;
        }

        public void GetJaggedArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = Random.Range(0, 2);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] == 1)
                        Debug.Log($"Index of an array element equal to '1': [{i}][{j}].\n");
                }
            }
        }

        public void Ex_3(int n)
        {
            int[,] array = new int[n, n];
            int[][] array2 = new int[n][];

            GetMaxMinArray(array);
            GetJaggedArray(array2);
        }

        public int[,] GetTwoDimensonalArray(int n, int m)
        {
            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    array[i, j] = Random.Range(-50, 51);
            }
            return array;
        }

        public void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Debug.Log(array[i, j]);
                }
                Debug.Log("\n");
            }
        }

        public int[][] GetRandomColumnsJaggedArray(int n = 5)
        {
            int[][] array = new int[n][];

            for (int i = 0; i < n; i++)
                array[i] = new int[Random.Range(0, 11)];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    array[i][j] = Random.Range(-50, 51);
            }

            return array;
        }

        public void PrintArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Debug.Log(array[i][j]);
                }
                Debug.Log("\n");
            }
        }

        public void Ex_6()
        {
            int value = 0;

            GenerationByValue(value);
            Debug.Log(value);

            GenerationByRef(ref value);
            Debug.Log(value);

        }

        public void GenerationByValue(int number)
        {
            number = Random.Range(-100, 101);
        }

        public void GenerationByRef(ref int number)
        {
            number = Random.Range(-100, 101);
        }

        public void Week(int day)
        {
            switch (day)
            {
                case 1:
                    Debug.Log("Monday");
                    break;
                case 2:
                    Debug.Log("Tuesday");
                    break;
                case 3:
                    Debug.Log("Wednesday");
                    break;
                case 4:
                    Debug.Log("Thursday");
                    break;
                case 5:
                    Debug.Log("Friday");
                    break;
                case 6:
                    Debug.Log("Saturday");
                    break;
                case 7:
                    Debug.Log("Sunday");
                    break;
                default:
                    Debug.Log("Other value");
                    break;
            }
        }
    }
}