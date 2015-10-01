using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
class WordCount
{
    static void Main()
    {
        var words = ReadLines("../../words.txt");
        var text = ReadLines("../../text.txt");

        FileStream fs = new FileStream();



    }

    static List<string> ReadLines(string file)
    {
        var lines = new List<string>();
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("Windows-1251"));
        using (reader)
        {
            string line = string.Empty;
            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    lines.Add(line.ToLower());
                }
            }
        }

        return lines;
    }
}
