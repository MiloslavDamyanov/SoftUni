using System;
using System.Collections.Generic;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        numbers.Sort();
        Console.WriteLine();
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}
