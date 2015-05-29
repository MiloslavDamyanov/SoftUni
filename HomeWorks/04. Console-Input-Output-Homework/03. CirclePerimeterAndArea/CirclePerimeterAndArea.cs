using System;
using System.Threading;
using System.Globalization;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Perimeter: {0:F2}\nArea: {1:F2}", perimeter, area);
    }
}