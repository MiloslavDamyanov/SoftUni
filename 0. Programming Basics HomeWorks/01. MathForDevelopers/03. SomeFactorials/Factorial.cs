namespace _03.SomeFactorials
{
    using System;
    using System.Numerics;

    public class Factorial
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 0;

            factorial = CalcFactorial(number);

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        public static BigInteger CalcFactorial(int inputNumber)
        {
            BigInteger factorial = inputNumber;

            while (inputNumber != 1)
            {
                inputNumber--;
                factorial *= inputNumber;
            }

            return factorial;
        }
    }
}
