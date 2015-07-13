using System;
using System.Collections.Generic;
using System.Linq;

class MatrixOfPalindromes
{
    static void Main()
    {
        string input = Console.ReadLine();
        var nums = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int row = int.Parse(nums[0]);
        int col = int.Parse(nums[1]);
        string[,] matrix = new string[row, col];
        int count = 0;
        for (int rows = 0; rows < row; rows++)
        {
            count = rows;
            for (int cols = 0; cols < col; cols++)
            {
                matrix[rows, cols] = ((char)('a' + rows) + "" + (char)('a' + count) + "" + (char)('a' + rows)).ToString();
                count++;
                Console.Write("{0} ", matrix[rows, cols]);
            }

            Console.WriteLine();
        }
    }
}