using System;
using System.Collections.Generic;

class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int length = ((n * 3) - 1) / 2;
        int dotCount = length;
        List<string> figure = new List<string>();
        string topAndBotton = new string('.', dotCount) + "*" + new string('.', dotCount);

        figure.Add(topAndBotton);
        for (int i = 0; i < n - 1; i++)
        {
            figure.Add(new string('.', i + 1) + "*" + new string('.', dotCount - 2) + "*" + new string('.', dotCount - 2) + "*" + new string('.', i + 1));
            dotCount--;
        }

        for (int i = 0; i < length - n; i++)
        {
            figure.Add(new string('.', n) + new string('*', n) + new string('.', n));
        }

        foreach (var item in figure)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(new string('*', n * 3));

        figure.Reverse();
        foreach (var item in figure)
        {
            Console.WriteLine(item);
        }
    }
}
