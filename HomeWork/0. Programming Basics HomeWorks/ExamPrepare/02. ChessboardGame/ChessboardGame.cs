using System;
using System.Collections.Generic;

class ChessboardGame
{
    static void Main()
    {
        int n = 5;
        string input = "Software University_2345";
        int[,] matrix = FillMatrix(n, input);
        List<int> list = new List<int>();
        int i = 0;
        int index = 0;
        int tempValue = 0;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++) // 1
            {
                if ((row > 0 && col > 0) && matrix[row, col] >= 65 && matrix[row, col] <= 90)
                {
                    if (row <= n - 1)
                    {
                        index = row++;
                    }

                    tempValue = matrix[row, col];
                    matrix[row, col] = matrix[index, col];
                    matrix[index, col] = tempValue;
                }

                list.Add(matrix[row, col]);
            }
        }

        for (int k = 0; k < list.Count; k++)
        {
            if (k % 2 == 0)
            {
                Console.Write(list[k] + " ");
            }
        }

        //  Console.WriteLine(whiteSum);
        //Console.WriteLine("white {0}\nblack {1}", whiteSumLine, blackSumLine);

    }

    private static int[,] FillMatrix(int n, string input)
    {
        int[,] matrix = new int[n, n];
        int index = 0;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (index > input.Length - 1)
                {
                    matrix[row, col] = 0;
                }
                else if ((input[index] >= 48 && input[index] <= 57) || (input[index] >= 65 && input[index] <= 90) || (input[index] >= 97 && input[index] <= 122))
                {
                    matrix[row, col] = (int)input[index];

                }
                else
                {
                    matrix[row, col] = 0;
                }

                index++;
            }
        }
        return matrix;
    }
}
