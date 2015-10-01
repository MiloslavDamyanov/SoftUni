using System;
using System.Collections.Generic;
using System.Linq;
class MaxSum
{
    static void Main()
    {

        int n = 4;
        int m = 5;
        int[,] matrix = {
                        {1, 5, 5, 2, 4},
                        {2, 1, 4, 14, 3},
                        {3, 7, 11, 2, 8},
                        {4, 8, 12, 16, 4}
                        };

        int maxRowLen = n - 3;
        int maxColLen = m - 3;
        int currentSum = 0;
        int sum = 0;
        int maxIndexRow = 0; // start index of matrix with max sum
        int maxIndexCol = 0; // start index of matrix with max sum

        for (int startRow = 0; startRow <= maxRowLen; startRow++)
        {
            for (int startCol = 0; startCol <= maxColLen; startCol++)
            {
                currentSum = Sum(startRow, startCol, matrix);
                if (currentSum > sum)
                {
                    sum = currentSum;
                    maxIndexRow = startRow;
                    maxIndexCol = startCol;
                }
            }
        }

        Console.WriteLine("Sum = {0}", sum);

        PrintMatrix(maxIndexRow, maxIndexCol, matrix);
    }

    private static int Sum(int startRow, int startCol, int[,] matrix)
    {
        int sum = 0;
        for (int row = startRow; row < startRow + 3; row++)
        {
            for (int col = startCol; col < startCol + 3; col++)
            {
                sum += matrix[row, col];
            }
        }

        return sum;
    }

    private static void PrintMatrix(int maxIndexRow, int maxIndexCol, int[,] matrix)
    {
        for (int row = maxIndexRow; row < maxIndexRow + 3; row++)
        {
            for (int col = maxIndexCol; col < maxIndexCol + +3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}