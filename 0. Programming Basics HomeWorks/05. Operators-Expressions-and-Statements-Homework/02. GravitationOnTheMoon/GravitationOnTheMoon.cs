using System;
using System.Threading;
using System.Globalization;

class GravitationOnTheMoon
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double weightOnTheEarth = double.Parse(Console.ReadLine());
        double weightOnTheMoon = ((double)17 / 100) * weightOnTheEarth;

        Console.WriteLine(weightOnTheMoon);
    }
}
