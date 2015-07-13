using System;
using System.Globalization;
using System.Threading;

class CompoundInterest
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double tvPrice = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        double i = double.Parse(Console.ReadLine()); // bank
        double f = double.Parse(Console.ReadLine()); // friends
        double bankLoan = tvPrice * Math.Pow((1 + i), n);
        double friendsLoan = tvPrice * (1 + f);

        if (bankLoan < friendsLoan)
        {
            Console.WriteLine("{0:F2} Bank", bankLoan);
        }
        else
        {
            Console.WriteLine("{0:F2} Friend", friendsLoan);
        }
    }
}