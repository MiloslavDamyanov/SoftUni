using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal result = 0, nextNumber = 1;

        while (n-- != 0)
        {
            Console.Write("{0} ",result);

            nextNumber = result + nextNumber;
            result = nextNumber - result;
        }

        Console.WriteLine();
    }
}