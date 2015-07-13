using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class PerimeterAndAreaOfPolygon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        List<double> pointsX = new List<double>();
        List<double> pointsY = new List<double>();
        List<double> distance = new List<double>();

        int n = int.Parse(Console.ReadLine());
        string coordinate = null;
        for (int i = 0; i < n; i++)
        {
            coordinate = Console.ReadLine();
            var point = coordinate.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            pointsX.Add(double.Parse(point[0].ToString()));
            pointsY.Add(double.Parse(point[1].ToString()));
        }

        double perimeter = CalcPerimeterOfPolygon(pointsX, pointsY, distance, n);
        double area = CalcAreaOfPolygon(pointsX, pointsY);

        Console.WriteLine("perimeter = {0:F2}", perimeter);
        Console.WriteLine("Area = {0:F2}", area);
    }

    private static double CalcAreaOfPolygon(List<double> pointsX, List<double> pointsY)
    {
        double area = 0;
        double res = 0;

        for (int i = 0; i < pointsX.Count - 1; i++)
        {
            res += pointsX[i] * pointsY[i + 1] - pointsY[i] * pointsX[i + 1];
        }

        area = Math.Abs(res / 2);
        return area;
    }

    private static double CalcPerimeterOfPolygon(List<double> pointsX, List<double> pointsY, List<double> distance, int n)
    {

        for (int i = 0, j = 0; i < n; i++)
        {
            if (j == n - 1)
            {
                j = 0;
            }
            else
            {
                j++;
            }
            double result = (Math.Pow(pointsX[j] - pointsX[i], 2)) + (Math.Pow(pointsY[j] - pointsY[i], 2));
            distance.Add(Math.Sqrt(result));
        }

        double perimeterOfPolygon = 0;
        distance.ForEach(d => perimeterOfPolygon += d);

        return perimeterOfPolygon;
    }
}