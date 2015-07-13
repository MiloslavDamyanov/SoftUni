using System;
using System.Threading;
using System.Globalization;

class TrapezoidsArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Side A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Side B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double h = double.Parse(Console.ReadLine());
        double area = 0.5 * (a + b) * h;
        Console.WriteLine("Area is: {0}", area);
    }
}