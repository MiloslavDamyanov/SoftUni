using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string pattern = @"([A-Z][\w\W]*?\b";
        Console.Write("keyword: ");
        string keyword = Console.ReadLine();
        pattern += keyword + @"\b[\w\W]*?[.!?])";
        Console.Write("text: ");
        string text = Console.ReadLine();

        RegexOptions option = RegexOptions.IgnoreCase | RegexOptions.Multiline;
        Regex regex = new Regex(pattern, option);
        MatchCollection matches = regex.Matches(text);
        Console.WriteLine();
        foreach (var item in matches)
        {
            Console.WriteLine(item);
        }
    }
}
