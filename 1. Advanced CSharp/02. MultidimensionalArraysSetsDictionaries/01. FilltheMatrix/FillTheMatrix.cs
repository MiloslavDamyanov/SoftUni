using System;
using System.Collections.Generic;
using System.Linq;

class FillTheMatrix
{
    static void Main()
    {
        int n = 4;
        int[,] matrix = new int[n, n];        

        FillMatrixA(n, matrix);
        PrintMatrix(n, matrix);

        Console.WriteLine();        
        matrix = new int[n, n];

        FillMatrixB(n, matrix);
        PrintMatrix(n, matrix);
    }

    private static void FillMatrixB(int n, int[,] matrix)
    {
        int element = 1;
        int row = 0;
        int col = 0;
        while (element <= (n * n))
        {
            matrix[row, col] = element;
            element++;

            if (row < n - 1)
            {
                row++;
            }
            else if (row == n - 1)
            {
                col++;
                while (row >= 0)
                {
                    matrix[row, col] = element;
                    element++;
                    row--;
                }

                if (row == -1)
                {
                    row = 0;
                }
                col++;
            }
        }
    }

    private static void FillMatrixA(int n, int[,] matrix)
    {
        int element = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = element;
                element++;
            }
        }
    }

    private static void PrintMatrix(int n, int[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }

            Console.WriteLine();
        }
    }
}
