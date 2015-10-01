using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class ReplaceTag
{
    static void Main()
    {
        var htmlTags = new List<string>();
        string input = Console.ReadLine();
        while (input != "")
        {
            htmlTags.Add(input);
            input = Console.ReadLine();
        }

        string result = string.Empty;
        for (int i = 0; i < htmlTags.Count; i++)
        {
            if (htmlTags[i].Contains("<a"))
            {
                string html = htmlTags[i]; // <a href="http://softuni.bg">SoftUni</a>
                string[] pattern = new string[] { "<a", "</a>" };
                string[] replace = new string[] { "[URL]", "[/URL]" };

                html = Regex.Replace(html, pattern[0], replace[0]);
                htmlTags[i] = Regex.Replace(html, pattern[1], replace[1]);
            }
        }

        htmlTags.ForEach(x => Console.WriteLine(x));
    }
}
