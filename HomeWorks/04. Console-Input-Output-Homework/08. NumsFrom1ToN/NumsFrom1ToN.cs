using System;

class NumsFrom1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i + 1);
        }
    }
}