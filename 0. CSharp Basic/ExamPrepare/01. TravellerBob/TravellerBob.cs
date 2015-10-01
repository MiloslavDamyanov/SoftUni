using System;
using System.Collections.Generic;
using System.Linq;

class TravellerBob
{
    static void Main()
    {
        string year = Console.ReadLine();
        int contracts = int.Parse(Console.ReadLine());  // number of month that Bob sign contracts 
        int family = int.Parse(Console.ReadLine());    // number month with family
        int familyTravels = 0;
        double travles = 0;

        int contractTravels = (4 * 3) * contracts;
        familyTravels = family * (2 * 2); 
        int normalnMonth = 12 - contracts - family;
        var normalTravels = ((4 * 3) * normalnMonth) * ((double)3 / (double)5);

        if (year == "leap")
        {
            double leap = (normalTravels + contractTravels + familyTravels) * (double)5 / 100;
            travles = (normalTravels + contractTravels + familyTravels) + leap;
        }
        else if (year == "normal")
        {
            travles = (normalTravels + contractTravels + familyTravels);
        }

        Console.WriteLine((int)travles);
    }
}