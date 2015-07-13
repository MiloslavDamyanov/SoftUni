using System;
using System.Collections.Generic;
using System.Text;

class KingOfThieves
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        List<string> figure = new List<string>();


        figure.Add(new string('-', n / 2) + new string(symbol, 1));

        for (int i = 1; i < n / 2; i++)
        {
            figure.Add(new string('-', (n / 2) - i) + new string(symbol, i + 1));
        }

        HorizontalMirror(figure);
        figure.Add(new string(symbol, n));
        VerticalMirror(figure);

        foreach (var line in figure)
        {
            Console.WriteLine(line);
        }

    }

    private static void HorizontalMirror(List<string> corner)
    {
        var flip = new List<string>();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < corner.Count; i++)
        {
            for (int index = corner.Count - 1; index >= 0; index--)
            {
                sb.Append(corner[i][index]);
            }

            corner[i] += sb.ToString();
            sb.Clear();
        }
    }

    private static void VerticalMirror(List<string> corner)
    {
        var flip = new List<string>(corner);
        flip.Reverse();

        // start from 1 to skip duplicate 
        for (int i = 1; i < flip.Count; i++)
        {
            corner.Add(flip[i]);
        }
    }
}
