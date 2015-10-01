using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string pattern = @"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,20}";
        string input = Console.ReadLine();
        var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        Regex regex = new Regex(pattern);
        foreach (var email in words)
        {
            if (regex.IsMatch(email))
            {
                string trimed = email.TrimEnd(new char[] { '.' });
                Console.WriteLine(trimed);
            }
        }
    }
}