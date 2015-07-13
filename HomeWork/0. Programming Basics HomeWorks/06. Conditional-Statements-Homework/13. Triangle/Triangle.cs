using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class Triangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        List<int> pointsX = new List<int>();
        List<int> pointsY = new List<int>();
        List<double> distance = new List<double>();

        for (int i = 0; i < 6; i++)
        {
            if (i % 2 == 0)
            {
                pointsX.Add(int.Parse(Console.ReadLine()));
            }
            else
            {
                pointsY.Add(int.Parse(Console.ReadLine()));
            }
        }

        double result = (Math.Pow(pointsX[1] - pointsX[0], 2)) + (Math.Pow(pointsY[1] - pointsY[0], 2));
        distance.Add(Math.Sqrt(result));

        result = (Math.Pow(pointsX[2] - pointsX[1], 2)) + (Math.Pow(pointsY[2] - pointsY[1], 2));
        distance.Add(Math.Sqrt(result));

        result = (Math.Pow(pointsX[0] - pointsX[2], 2)) + (Math.Pow(pointsY[0] - pointsY[2], 2));
        distance.Add(Math.Sqrt(result));

        double sum = 0;
        for (int index = 0; index < distance.Count; index++)
        {
            sum += distance[index];
        }

        double perimeter = sum / 2;

        double area = Math.Sqrt(perimeter * ((perimeter - distance[0]) * (perimeter - distance[1]) * (perimeter - distance[2])));

        if (distance[0] + distance[1] > distance[2] && distance[1] + distance[2] > distance[0] && distance[0] + distance[2] > distance[1])
        {
            Console.WriteLine("Yes\n{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No\n{0:F2}", distance[0]);
        }
    }

}