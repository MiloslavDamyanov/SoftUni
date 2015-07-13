using System;
using System.Threading;
using System.Globalization;

class NumberComparer
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = 10;
        double b = 5;

        Console.WriteLine("Greater is: {0}", Math.Max(a, b));
    }
}