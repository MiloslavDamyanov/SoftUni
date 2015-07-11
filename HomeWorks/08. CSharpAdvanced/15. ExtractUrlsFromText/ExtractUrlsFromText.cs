using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractUrlsFromText
{
    static void Main()
    {
        string text = "	The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.";

        char[] separator = { ' ' };
        var list = text.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Contains("http://") || list[i].Contains("www."))
            {
                if (list[i][list[i].Length - 1] == '.' || list[i][list[i].Length - 1] == ',')
                {
                    var sb = new StringBuilder();
                    for (int j = 0; j < list[i].Length - 1; j++)
                    {
                        sb.Append(list[i][j]);
                    }

                    Console.WriteLine(sb.ToString().TrimStart());
                    sb.Clear();
                }
                else
                {
                    Console.WriteLine(list[i].TrimStart());
                }
            }
        }
    }
}