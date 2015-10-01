using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        var lines = ReadLines();
        WriteToFile(lines);
        ReadFilePrint();
    }

    private static void ReadFilePrint()
    {
        StreamReader reader = new StreamReader("../../new.txt");
        using (reader)
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
    private static void WriteToFile(List<string> lines)
    {
        StreamWriter writer = new StreamWriter("../../new.txt");
        int lineNumber = 1;
        for (int i = 0; i < lines.Count; i++)
        {
            string temp = string.Format("{0}. {1}", lineNumber, lines[i]);
            lines[i] = temp;
            lineNumber++;
        }
        using (writer)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                writer.WriteLine(lines[i]);
            }
        }
    }
    static List<string> ReadLines()
    {
        var lines = new List<string>();
        StreamReader reader = new StreamReader("../../text.txt", Encoding.GetEncoding("Windows-1251"));
        using (reader)
        {
            string line = string.Empty;
            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    lines.Add(line);
                }
            }
        }

        return lines;
    }
}