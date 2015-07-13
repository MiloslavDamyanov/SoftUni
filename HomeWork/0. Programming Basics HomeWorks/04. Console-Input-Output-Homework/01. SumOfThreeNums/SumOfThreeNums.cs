using System;
using System.Threading;
using System.Globalization;

class SumOfThreeNums
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double[] input = new double[3];
        double sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("{0}. Enter number: ", i + 1);
            input[i] = double.Parse(Console.ReadLine());
            sum += input[i];
        }

        Console.WriteLine("Sum = {0}", sum);
    }
}