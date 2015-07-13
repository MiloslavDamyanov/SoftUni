using System;

class RandomNumsGivenRange
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Max: ");
        int max = int.Parse(Console.ReadLine());
        var rng = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", rng.Next(min, max + 1));
        }

        Console.WriteLine();
    }
}
