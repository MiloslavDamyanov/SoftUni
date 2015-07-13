using System;
using System.Collections.Generic;
using System.Linq;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string keyWord = Console.ReadLine();

        char[,] matrix = new char[n, n];
        List<int> weight = new List<int>();
        List<char> capitalLetters = new List<char>();
        List<char> lowerLetters = new List<char>();

        AddLetters(capitalLetters, lowerLetters);
        FillMatrix(n, keyWord, matrix);
        GetWeight(n, matrix, weight, capitalLetters, lowerLetters);

        Console.WriteLine("{0} - {1}", weight.IndexOf(weight.Max()), weight.Max());
    }

    private static void GetWeight(int n, char[,] matrix, List<int> weight, List<char> capitalLetters, List<char> lowerLetters)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (capitalLetters.Contains(matrix[i, j]))
                {
                    sum += (capitalLetters.IndexOf(matrix[i, j]) + 1) * 10;
                }
                else if (lowerLetters.Contains(matrix[i, j]))
                {
                    sum += (lowerLetters.IndexOf(matrix[i, j]) + 1) * 10;
                }
            }

            weight.Add(sum);
            sum = 0;
        }
    }

    private static void AddLetters(List<char> capitalLetters, List<char> lowerLetters)
    {
        char lower = 'a';
        char cap = 'A';
        for (int i = 0; i < 26; i++, cap++, lower++)
        {
            capitalLetters.Add(cap);
            lowerLetters.Add(lower);
        }
    }

    private static int FillMatrix(int n, string keyWord, char[,] matrix)
    {

        string direction = "right";
        int currentRow = 0;
        int currentCol = 0;
        int index = 0;

        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right" && (currentCol >= n || matrix[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow++;
                direction = "down";
            }
            else if (direction == "down" && (currentRow >= n || matrix[currentRow, currentCol] != 0))
            {
                currentRow--;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol++;
                direction = "right";
            }

            if (index == keyWord.Length)
            {
                index = 0;
            }
            matrix[currentRow, currentCol] = keyWord[index];
            index++;
            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }
        return index;
    }
}
