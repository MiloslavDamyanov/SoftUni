namespace _02.SomeFibonacciPrimes
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class FibonacciPrimes
    {
        static void Main()
        {
            int endOfSequence = int.Parse(Console.ReadLine());
            decimal result = 0, nextNumber = 1;
            List<decimal> fibonacci = new List<decimal>();

            while (endOfSequence-- != 0)
            {
                fibonacci.Add(result);

                nextNumber = result + nextNumber;
                result = nextNumber - result;
            }

            int input = int.Parse(Console.ReadLine());
            List<int> primeNum = new List<int>();
            int count = 1;

            while (primeNum.Count != input)
            {
                if (IsPrime(count))
                {
                    primeNum.Add(count);
                }

                count++;
            }

            Console.WriteLine(primeNum[primeNum.Count - 1]);
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
}
