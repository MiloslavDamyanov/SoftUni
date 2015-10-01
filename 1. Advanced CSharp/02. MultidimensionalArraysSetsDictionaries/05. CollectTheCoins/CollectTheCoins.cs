using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class CollectTheCoins
{
    static void Main()
    {
        List<string> input = new List<string>();
        Input(input);
        var matrix = AddToMatrix(input);
        int commandsLength = input[input.Count - 1].Length;
        int index = input.Count - 1;
        // V>>^^>>>VVV<<
        int row = 0;
        int col = 0;
        int walls = 0;
        int coins = 0;
        for (int i = 0; i < commandsLength; i++)
        {
            switch (input[index][i])
            {
                case 'V':
                    row++;
                    break;
                case '>':
                    col++;
                    break;
                case '^':
                    row--;
                    break;
                case '<':
                    col--;
                    break;
                default:
                    break;
            }

            // check is negative or bigger
            if (row < 0)
            {
                row = 0;
                //walls++;
            }
            else if (row > matrix.GetLength(0) - 1) // with -1 or without or =
            {
                //walls++;
                row = matrix.GetLength(0) - 1;
            }

            if (col < 0)
            {
                col = 0;
                //walls++;
            }
            //else if (col > matrix.GetLength(1) - 1)
            //{
            //    col = matrix.GetLength(1) - 1;
            //    walls++;
            //}

            if (matrix[row, col] == '.')
            {
                walls++;
                col = matrix.GetLength(1) - 1;
            }
            // check for Coins
            if (matrix[row, col] == '$')
            {
                coins++;
            }
        }


        Console.WriteLine("Coins collected: {0}\nWalls hit: {1}\n", coins, walls);
        //PrintMatrix(matrix);

    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static char[,] AddToMatrix(List<string> input)
    {
        var matrix = new char[input.Count - 1, input[0].Length];
        for (int row = 0; row < input.Count - 1; row++)
        {
            for (int col = 0; col < input[0].Length; col++)
            {
                matrix[row, col] = input[row][col];
            }
        }

        return matrix;
    }

    private static void Input(List<string> input)
    {

        for (int i = 0; i < 5; i++)
        {
            input.Add(Console.ReadLine());
        }

        int longestWord = 0;
        for (int i = 0; i < input.Count - 1; i++)
        {
            if (input[i].Length > longestWord)
            {
                longestWord = input[i].Length;
            }
        }

        for (int i = 0; i < input.Count - 1; i++)
        {
            if (input[i].Length < longestWord)
            {
                input[i] = input[i] + new string('.', longestWord - input[i].Length);
            }
        }
    }
}