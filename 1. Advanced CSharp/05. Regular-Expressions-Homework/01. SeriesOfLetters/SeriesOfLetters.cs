using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();

        string pattern = @"([a-z]|[A-Z])\1+";
        string replacement = "$1";
        string result = Regex.Replace(input, pattern, replacement);
      
        Console.WriteLine(result);
    }
}
 