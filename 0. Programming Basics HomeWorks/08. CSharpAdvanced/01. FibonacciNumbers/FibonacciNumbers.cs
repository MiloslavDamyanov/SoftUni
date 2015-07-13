using System;
using System.Collections.Generic;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        decimal result = 1, nextNumber = 1;
        while (n-- != 0)
        {
            nextNumber = result + nextNumber;
            result = nextNumber - result;
        }

        Console.WriteLine(result);
    }
}