using System;
using System.Threading;
using System.Globalization;

class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Width:");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height:");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * width + 2 * height;
        double area = width * height;

        Console.WriteLine("Perimeter:{0}\nArea:{1}", perimeter, area);
    }
}
