using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }

    private static int GetIndexOfFirstElementLargerThanNeighbours(int[] sequence)
    {
        int index = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            int next = i;
            int prev = i;

            if (prev > 0)
            {
                prev--;
            }

            if (next < sequence.Length - 1)
            {
                next++;
            }

            if (sequence[i] > sequence[next] && sequence[i] > sequence[prev])
            {
                index = i;
            }

        }

        if (index == 0)
        {
            index = -1;
        }

        return index;
    }
}
