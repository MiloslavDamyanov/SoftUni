using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class FourFactor
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double fg = int.Parse(Console.ReadLine());
        double fga = int.Parse(Console.ReadLine());
        double threeP = int.Parse(Console.ReadLine());
        double tov = int.Parse(Console.ReadLine());
        double orb = int.Parse(Console.ReadLine());
        double OppDrb = int.Parse(Console.ReadLine());
        double ft = int.Parse(Console.ReadLine());
        double fta = int.Parse(Console.ReadLine());

        double efgP = (fg + 0.5 * threeP) / fga;

        double tovP = ((tov) / (fga + 0.44 * fta + tov));

        double orbP = (orb / (orb + OppDrb));

        double ftP = ft / fga;

        Console.WriteLine("eFG% {0:F3}", efgP);
        Console.WriteLine("TOV% {0:F3}", tovP);
        Console.WriteLine("ORB% {0:F3}", orbP);
        Console.WriteLine("FT% {0:F3}", ftP);
    }
}