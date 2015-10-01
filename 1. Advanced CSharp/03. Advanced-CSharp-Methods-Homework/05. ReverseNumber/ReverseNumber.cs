using System;
using System.Globalization;
using System.Threading;

class ReverseNumber
{
    static void Main()
    {
        double reversed = GetReversedNumber(123.45);
        Console.WriteLine(reversed);
    }

    private static double GetReversedNumber(double number)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string reversed = null;
        string num = number.ToString();
        for (int i = num.Length - 1; i >= 0; i--)
        {
            reversed += num[i];
        }

        return double.Parse(reversed);
    }
}