using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class NumberCalc
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double[] doubleNumbers = { 1, 4, 5, 9, 12, 7, 90, 3, 2, 8 };
        decimal[] deciamlNumbers = { 5, 10, 1, 3, -5, 14, 200 };
        int[] intNumbers = { 1, 1, 5, 3, 3 };
        long[] longNumber = { 3, 5, 3, 1, 1 };

        Console.WriteLine("Min - {0}", Min(longNumber));
        Console.WriteLine("Max - {0}", Max(longNumber));
        Console.WriteLine("Sum - {0}", Sum(longNumber));
        Console.WriteLine("Average - {0}", Average(longNumber));
        Console.WriteLine("Product - {0}", Product(longNumber));

    }

    private static T Product<T>(T[] numbers)
    {
        dynamic product = 1;
        foreach (var num in numbers)
        {
            product *= num;
        }

        return product;
    }

    private static T Sum<T>(T[] numbers)
    {
        dynamic sum = 0;

        foreach (var num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    private static double Average<T>(T[] numbers)
    {
        T sum = Sum(numbers);

        return double.Parse(sum.ToString()) / numbers.Length;
    }

    private static T Max<T>(T[] numbers)
    {
        dynamic max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }

    private static T Min<T>(T[] numbers)
    {
        dynamic min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        return min;
    }
}