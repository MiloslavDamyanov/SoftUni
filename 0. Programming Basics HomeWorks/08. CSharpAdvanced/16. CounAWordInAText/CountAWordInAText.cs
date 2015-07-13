using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class CounAWordInAText
{
    static void Main()
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
        string str = Console.ReadLine().ToLower();
        string input = Console.ReadLine().ToLower();
        List<string> list = new List<string>();

        int count = 0;
        char[] separator = { ' ', ',', '.', '“', '”', '!', '?', '-', '@', '<', '>', '(', ')', '"', '/' };
        var splitted = input.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
        for (int i = 0; i < splitted.Count; i++)
        {
            if (splitted[i] == str)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
