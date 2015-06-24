using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int col = 0;
        int fill = 0;
        for (int row = 0; row <= n - 1; row++)
        {
            for (col = 0; col <= n - 1; col++)
            {
                matrix[row, col] = fill + 1;
                fill++;
            }

            fill = row + 1;
        }

        for (int row = 0; row <= n - 1; row++)
        {
            for (col = 0; col <= n - 1; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}
