using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] separator = { ' ' };
        var letters = input.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

        letters.Sort();
        List<string> results = new List<string>();
        int counter = 1;
        int nextIndex = 1;
        for (int i = 0; i < letters.Count; i++)
        {
            if (letters[i] == letters[nextIndex])
            {
                counter++;
            }
            else if (letters[i] != letters[nextIndex])
            {
                results.Add(string.Format(letters[i] + " -> " + counter));
                counter = 1;
            }

            if (i == letters.Count - 1)
            {
                --counter;
                results.Add(string.Format(letters[i] + " -> " + counter));
            }

            if (nextIndex < letters.Count - 1)
            {
                nextIndex++;
            }
        }

        var result = string.Join("\n", results);
        Console.WriteLine(result);
    }
}