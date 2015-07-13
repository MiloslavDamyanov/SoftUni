using System;
using System.Threading;
using System.Globalization;

class ExchangeIfGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine(b + " " + a);
        }
        else
        {
            Console.WriteLine(a + " " + b);
        }
    }
}