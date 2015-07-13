using System;
using System.Collections.Generic;

class PrimesInRange
{
    static void Main()
    {
        Console.Write("Start number: ");
        ulong startNum = ulong.Parse(Console.ReadLine());
        Console.Write("End number: ");
        ulong endNum = ulong.Parse(Console.ReadLine());
        var primeNums = FindPrimesInRange(startNum, endNum);

        for (int i = 0; i < primeNums.Count; i++)
        {
            if (i < primeNums.Count - 1)
            {
                Console.Write(primeNums[i] + ", ");
            }
            else
            {
                Console.Write(primeNums[i]);
            }
        }

        Console.WriteLine();
    }

    private static List<ulong> FindPrimesInRange(ulong startNum, ulong endNum)
    {
        var primes = new List<ulong>();
        for (ulong i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }

        return primes;
    }

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
