using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TexstFilter
{
    static void Main()
    {
        string banWords = Console.ReadLine();
        string text = Console.ReadLine();

        var banList = banWords.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        StringBuilder sb = new StringBuilder(text);
        for (int i = 0; i < banList.Count; i++)
        {
            sb.Replace(banList[i], new string('*', banList[i].Length));
        }

        text = sb.ToString();
        sb.Clear();
        Console.WriteLine("\n\n" + text);

    }
}