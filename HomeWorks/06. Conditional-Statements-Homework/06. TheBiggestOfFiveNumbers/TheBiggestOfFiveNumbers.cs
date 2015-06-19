using System;
using System.Globalization;
using System.Threading;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e: ");
        double e = double.Parse(Console.ReadLine());

        double biggestValue = double.MinValue;
        if (a > b)
        {
            biggestValue = a;
        }

        if (b > a)
        {
            biggestValue = b;
        }

        if (c < d && d > biggestValue)
        {
            biggestValue = d;
        }

        if (d < c && c > biggestValue)
        {
            biggestValue = c;
        }

        if (e > biggestValue)
        {
            biggestValue = e;
        }

        Console.WriteLine("Biggest value is {0}", biggestValue);
    }
}
