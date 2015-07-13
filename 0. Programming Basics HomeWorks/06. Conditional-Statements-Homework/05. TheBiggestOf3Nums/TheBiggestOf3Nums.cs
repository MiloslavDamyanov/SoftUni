using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;

class TheBiggestOf3Nums
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        List<double> nums = new List<double>();
        for (int i = 0; i < 3; i++)
        {
            Console.Write("{0}: ", i + 1);
            nums.Add(double.Parse(Console.ReadLine()));
        }

        double biggest = double.MinValue;
        for (int i = 0; i < nums.Count; i++)
        {
            if (biggest < nums[i])
            {
                biggest = nums[i];
            }
        }

        Console.WriteLine("Biggest value is {0}", biggest);

        // Console.WriteLine("Max number is: {0}", nums.Max());
    }
}
