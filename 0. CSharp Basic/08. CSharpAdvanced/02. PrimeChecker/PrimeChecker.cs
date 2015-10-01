using System;
using System.Collections.Generic;

class PrimeChecker
{
    static void Main()
    {
        Console.Write("n: ");
        ulong n = ulong.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
    }

    //private static void IsPrime(ulong n)
    //{
    //    bool isPrime = false;

    //    int naturalNumCount = 1;
    //    if (n != 1)
    //    {
    //        for (ulong i = 2; i <= n; i++)
    //        {

    //            if (n % i == 0)
    //            {
    //                naturalNumCount++;
    //            }
    //        }

    //        if (naturalNumCount == 2)
    //        {
    //            isPrime = true;
    //        }
    //    }

    //    Console.WriteLine("{0} - {1}", n, isPrime);
    //}

    private static bool IsPrime(ulong number)
    {
        if ((number & 1) == 0)
        {
            if (number == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        for (ulong i = 3; (i * i) <= number; i += 2)
        {
            if ((number % i) == 0)
            {
                return false;
            }
        }

        return number != 1;
    }
}