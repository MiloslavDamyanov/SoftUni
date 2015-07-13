using System;
using System.Collections.Generic;
using System.Text;

class HorizontalFlip
{
    static void Main()
    {
        int n = 7;
        List<string> upperLeftCorner = new List<string>();
        List<string> right = new List<string>();

        int dashCount = (n + 1) - (n - 1);
        for (int i = 0; i < n; i++)
        {
            upperLeftCorner.Add(new string('-', n - i) + "*" + new string('.', dashCount - 2));
            dashCount++;
        }

        HorizontalMirror(upperLeftCorner);
        VerticalMirror(upperLeftCorner);

        foreach (var item in upperLeftCorner)
        {
            Console.WriteLine(item);
        }
    }

    private static void VerticalMirror(List<string> corner)
    {
        var flip = new List<string>(corner);
        flip.Reverse();

        foreach (var item in flip)
        {
            corner.Add(item);
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
}