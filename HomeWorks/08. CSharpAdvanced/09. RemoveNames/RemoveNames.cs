using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        string firstLine = Console.ReadLine();
        string secondLine = Console.ReadLine();
        char[] separaor = { ' ' };
        var arrayOne = firstLine.Split(separaor, StringSplitOptions.RemoveEmptyEntries).ToList();
        var arrayTwo = secondLine.Split(separaor, StringSplitOptions.RemoveEmptyEntries).ToList();

        for (int i = 0; i < arrayTwo.Count; i++)
        {
            for (int j = 0; j < arrayOne.Count; j++)
            {
                if (arrayTwo[i] == arrayOne[j])
                {
                    arrayOne.RemoveAt(j);
                    --j;
                }
            }
        }

        string result = string.Join(" ", arrayOne);
        Console.WriteLine(result);
    }
}