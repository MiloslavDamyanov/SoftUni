using System;

class PointInACircle
{
    static void Main()
    {
        double x = 0;
        double y = 1;

        double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        Console.WriteLine(result <= 2);
    }
}