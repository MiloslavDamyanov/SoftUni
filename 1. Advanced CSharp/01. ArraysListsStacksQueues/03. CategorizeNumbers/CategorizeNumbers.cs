using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class CategorizeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = "1.2 -4 5.00 12211 93.003 4 2.2";
        List<double> doubleList = new List<double>();
        List<int> intList = new List<int>();

        SplitDoubleOrInt(input, doubleList, intList);
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}\n", string.Join(", ", doubleList), doubleList.Min(), doubleList.Max(), doubleList.Sum(), doubleList.Sum() / doubleList.Count);
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}\n", string.Join(", ", intList), intList.Min(), intList.Max(), intList.Sum(), intList.Sum() / intList.Count);
    }

    private static void SplitDoubleOrInt(string input, List<double> doubleList, List<int> intList)
    {
        var array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        double doubleNumber = 0;
        int intNumber = 0;
        for (int i = 0; i < array.Count; i++)
        {
            double number = double.Parse(array[i]);
            var fraction = number / 1;
            string value = fraction.ToString();

            if (Int32.TryParse(value, out intNumber))
            {
                intList.Add(intNumber);
            }
            else if (Double.TryParse(value, out doubleNumber))
            {
                doubleList.Add(doubleNumber);
            }
        }
    }
}