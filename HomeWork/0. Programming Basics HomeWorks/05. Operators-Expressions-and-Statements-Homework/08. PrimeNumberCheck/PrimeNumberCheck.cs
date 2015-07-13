using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
    }

    public static bool IsPrime(int number)
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
        else if (number < 0)
        {
            return false;
        }

        for (int i = 3; (i * i) <= number; i += 2)
        {
            if ((number % i) == 0)
            {
                return false;
            }
        }

        return number != 1;
    }
}