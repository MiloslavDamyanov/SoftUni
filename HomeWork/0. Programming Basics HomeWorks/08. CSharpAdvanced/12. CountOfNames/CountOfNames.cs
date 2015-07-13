using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] separator = { ' ' };
        var names = input.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

        names.Sort();
        List<string> results = new List<string>();
        int counter = 1;
        int nextIndex = 1;
        for (int i = 0; i < names.Count; i++)
        {
            if (names[i] == names[nextIndex])
            {
                counter++;
            }
            else if (names[i] != names[nextIndex])
            {
                results.Add(string.Format(names[i] + " -> " + counter));
                counter = 1;
            }

            if (i == names.Count - 1)
            {
                --counter;
                results.Add(string.Format(names[i] + " -> " + counter));
            }

            if (nextIndex < names.Count - 1)
            {
                nextIndex++;
            }
        }
        
        var result = string.Join("\n", results);
        Console.WriteLine(result);
    }
}