using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        var values = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var numbers = new List<int>();
        var result = new List<string>();
        for (int i = 0; i < values.Count; i++)
        {
            numbers.Add(int.Parse(values[i]));
        }

        int nextIndex = 1;
        string value = null;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < numbers[nextIndex])
            {
                value += string.Format("{0} ", numbers[i]);
            }
            else if (numbers[i] >= numbers[nextIndex])
            {
                value += string.Format("{0} ", numbers[i]);
                Console.WriteLine(value);
                result.Add(value);
                value = null;
            }

            if (nextIndex < numbers.Count - 1)
            {
                nextIndex++;
            }
        }

        int longest = result[0].Length;
        int index = 0;
        for (int i = 0; i < result.Count; i++)
        {
            if (longest < result[i].Length)
            {
                longest = result[i].Length;
                index = i;
            }
        }

        Console.WriteLine("Longest: {0}", result[index]);
    }
}