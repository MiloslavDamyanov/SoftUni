using System;
using System.Threading;
using System.Globalization;

class QuadraticEquation
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
        double d = 0;

        d = Math.Pow(b, 2) - (4 * a * (c));
        double x1, x2 = 0;
        x1 = (-b - Math.Sqrt(d)) / (2 * a);
        x2 = (-b + Math.Sqrt(d)) / (2 * a);

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            Console.WriteLine("x1: {0:F1}\nx2:{1:F1}", x1, x2);
        }
    }
}