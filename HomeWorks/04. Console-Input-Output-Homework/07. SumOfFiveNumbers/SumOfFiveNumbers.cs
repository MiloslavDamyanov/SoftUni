using System;
using System.Threading;
using System.Globalization;

class SumOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input = Console.ReadLine();
        char[] symbols = new char[] { ' ' };
        string[] arr = input.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += double.Parse(arr[i]);
        }

        Console.WriteLine(sum);
    }
}