using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] separator = { ' ', '.' };
        var list = input.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

        List<int> length = new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            length.Add(list[i].Length);
        }

        for (int i = 0; i < length.Count; i++)
        {
            if (list[i].Length == length.Max())
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}