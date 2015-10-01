using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class SequenceInMatrix
{
    static void Main()
    {
        string[,] matrix = 
        {
            {"s","qq","s" },
            {"pp","pp","s"},
            {"pp","qq","s"}
        };

        List<string> line = new List<string>();
        int nextIndex = 0;
        string temp = string.Empty;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (nextIndex < matrix.GetLength(0) - 1)
                {
                    nextIndex++;
                }

                if (matrix[row, col] == matrix[nextIndex, col])
                {
                    temp += string.Format(matrix[row, col] + " ");
                }
                else if (matrix[row, col] != matrix[nextIndex, col])
                {
                    line.Add(matrix[row, col]);
                }
            }

            line.Add(temp);
            temp = null;
            nextIndex = 0;
        }

        int longestSequence = 0;
        for (int i = 0; i < line.Count; i++)
        {
            var arr = line[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length > longestSequence)
            {
                longestSequence = i;
            }

            line[i] = string.Join(", ", arr);
        }

        Console.WriteLine(line[longestSequence]);
    }
}