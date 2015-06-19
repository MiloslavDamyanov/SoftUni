using System;

class Volleyball
{
    static void Main()
    {
        string input = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double hometown = double.Parse(Console.ReadLine());
        double totalWeekends = 48;
        double normalWeekends = totalWeekends - hometown;
        double plays = 0;
        double additional = 15;

        normalWeekends = normalWeekends * (3d / 4); 
        plays = holidays * (2d / 3);
        plays = plays + normalWeekends + hometown;

        if (input == "leap")
        {
            double totalPlays = plays + (additional / 100) * plays;
            Console.WriteLine((int)totalPlays);
        }
        else if (input == "normal")
        {
            double totalPlays = plays;
            Console.WriteLine((int)totalPlays);
        }
    }
}