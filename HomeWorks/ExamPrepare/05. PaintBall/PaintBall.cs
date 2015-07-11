using System;
using System.Collections.Generic;
using System.Linq;

class PaintBall
{
    static void Main()
    {
        List<string> position = new List<string>();
        var matrix = new int[10, 10];
        Input(position);
        FillMatrix(matrix);
        Shoot(position, matrix);
        Console.WriteLine(Result(matrix));
       // PrintMatrix(matrix);
    }

    private static int Result(int[,] matrix)
    {
        List<int> decNumber = new List<int>();
        string binary = null;
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                binary += matrix[row, col];
            }

            decNumber.Add(Convert.ToInt32(binary, 2));
            binary = null;
        }

        return decNumber.Sum();
    }

    private static void Shoot(List<string> position, int[,] matrix)
    {
        int count = 0;
        for (int i = 0; i < position.Count; i++)
        {
            var input = position[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int centerRow = int.Parse(input[0]);
            int centerCol = 0;
            if (int.Parse(input[1]) - 1 > 0)
            {
                centerCol = int.Parse(input[1]) - 1; // check -1 ? 
            }
            else
            {
                centerCol = int.Parse(input[1]);
            }

            // center
            // matrix[centerRow, centerCol] = 0;

            // upper left corner
            if (centerRow - int.Parse(input[2]) >= 0 && centerCol - int.Parse(input[2]) >= 0)
            {
                centerRow -= int.Parse(input[2]);
                centerCol -= int.Parse(input[2]);
            }
            else
            {
                while (centerRow != 0)
                {
                    centerRow--;

                }
                while (centerCol != 0)
                {
                    centerCol--;
                }
            }

            int rowsLength = 0;
            int colsLength = 0;
            if (int.Parse(input[1]) + centerRow > 9)
            {
                rowsLength = 9;
            }

            if (int.Parse(input[1]) + centerCol > 10)
            {
                colsLength = 9;
            }
            else
            {
                rowsLength = int.Parse(input[1]) + int.Parse(input[2]) >= 9 ? 9 : int.Parse(input[1]) + int.Parse(input[2]);
                colsLength = int.Parse(input[1]) + int.Parse(input[2]) >= 9 ? 9 : int.Parse(input[1]) + int.Parse(input[2]);
            }


            for (int j = centerRow; j < rowsLength; j++)
            {
                for (int k = centerCol; k < colsLength; k++)
                {
                    if (matrix[j, k] == 1)
                    {
                        matrix[j, k] = 0;
                    }
                    else
                    {
                        matrix[j, k] = 1;
                    }
                }
            }


        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }

    private static void FillMatrix(int[,] matrix)
    {

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                matrix[row, col] = 1;
            }
        }
    }

    private static void Input(List<string> position)
    {
        string input = null;
        while (input != "End")
        {
            input = Console.ReadLine();
            if (input != "End")
            {
                position.Add(input);
            }

            if (position.Count == 25)
            {
                break;
            }
        }
    }
}