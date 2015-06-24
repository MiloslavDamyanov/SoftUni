using System;
using System.Numerics;

class TrailingZeroesInNFact
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        BigInteger factorial = 1;

        Console.Write("Calculating factorial ...");
        while (count != n + 1)
        {
            factorial *= count;
            ++count;
        }
        Console.Clear();
        Console.WriteLine(n);
        Console.WriteLine("Calculating factorial ... done!");
        Console.WriteLine("wait...");

        BigInteger result = 0;
        count = 0;
        while (result == 0)
        {
            result = factorial % 10;
            factorial /= 10;
            if (result == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count + " trailing zeroes of {0}!", n);
    }
}