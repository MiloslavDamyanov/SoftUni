using System;
using System.Threading;
using System.Globalization;

class MinMaxSumAverage
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int max = 0;
        int sum = 0;
        int min = 0;
        double average = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        average = sum / (double)n;
        max = arr[0];
        min = arr[0];
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }

            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine("\nmin = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}", min, max, sum, average);
    }
}