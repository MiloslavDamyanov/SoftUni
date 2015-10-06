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
        var word = ReadLines("../../words.txt");
        var text = ReadLines("../../text.txt");
        var result = new Dictionary<string, int>();
        var finalResult = new List<string>();

        Counting(word, text, result);

        var items = Sort(result);

        foreach (KeyValuePair<string, int> pair in items)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            finalResult.Add(string.Format("{0}: {1}", pair.Key, pair.Value));
        }

        WriteToFIle(finalResult);
    }

    static void WriteToFIle(List<string> list)
    {
        string result = @"..\..\result.txt";
        StreamWriter writer = new StreamWriter(result, false);
        using (writer)
        {
            foreach (var item in list)
            {
                writer.WriteLine(item);
            }
        }
    }
    private static IOrderedEnumerable<KeyValuePair<string, int>> Sort(Dictionary<string, int> result)
    {
        var items = from pair in result
                    orderby pair.Value descending
                    select pair;
        return items;
    }

    private static void Counting(List<string> word, List<string> text, Dictionary<string, int> result)
    {
        char[] separator = { ' ', ',', '.', '“', '”', '!', '?', '-', '@', '<', '>', '(', ')', '"', '/' };
        int count = 0;
        for (int i = 0; i < word.Count; i++)
        {
            for (int j = 0; j < text.Count; j++)
            {
                var words = text[j].Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int k = 0; k < words.Count; k++)
                {
                    if (words[k] == word[i])
                    {
                        count++;
                    }
                }
            }

            result.Add(word[i], count);
            count = 0;
        }
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
