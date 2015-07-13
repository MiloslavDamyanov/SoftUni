using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class OddEvenElements
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        char[] separator = { ' ' };
        string[] arr = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        List<double> array = new List<double>();
        List<double> odd = new List<double>();
        List<double> even = new List<double>();
        for (int i = 0; i < arr.Length; i++)
        {
            array.Add(double.Parse(arr[i]));
        }

        double oddSum = 0, oddMin = 0, oddMax = 0, evenSum = 0, evenMin = 0, evenMax = 0;
        for (int i = 0; i < array.Count; i++)
        {
            if (i % 2 == 0)
            {
                oddSum += array[i];
                odd.Add(array[i]);
            }
            else if (i % 2 != 0)
            {
                evenSum += array[i];
                even.Add(array[i]);
            }
        }

        oddMin = odd.Count != 0 ? odd.Min() : 0.0;
        oddMax = odd.Count != 0 ? odd.Max() : 0.0;
        evenMin = even.Count != 0 ? even.Min() : 0.0;
        evenMax = even.Count != 0 ? even.Max() : 0.0;

        Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", oddSum != 0 ? oddSum.ToString() : "No", oddMin != 0 ? oddMin.ToString() : "No", oddMax != 0 ? oddMax.ToString() : "No", evenSum != 0 ? evenSum.ToString() : "No", evenMin != 0 ? evenMin.ToString() : "No", evenMax != 0 ? evenMax.ToString() : "No");
    }
}