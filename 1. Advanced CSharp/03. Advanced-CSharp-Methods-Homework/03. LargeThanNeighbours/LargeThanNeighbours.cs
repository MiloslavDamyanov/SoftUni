using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LargeThanNeighbours
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }

    private static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        int next = i;
        int prev = i;
        if (next < numbers.Length - 1)
        {
            next++;
        }

        if (prev > 0)
        {
            prev--;
        }
        if (numbers[i] >= numbers[next] && numbers[i] >= numbers[prev])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
