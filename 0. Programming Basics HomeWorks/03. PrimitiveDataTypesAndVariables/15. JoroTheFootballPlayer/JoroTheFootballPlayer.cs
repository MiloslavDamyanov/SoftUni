using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        int totalWeekend = 52;
        float result = 0;
        int additionalPlays = 3;

        // input
        string isLeapYear = Console.ReadLine();        // "t" leap, "f" not leap
        int holidays = int.Parse(Console.ReadLine());  // 1
        int hometown = int.Parse(Console.ReadLine());  // 2


        if (isLeapYear == "t")
        {
            // leap year
            result = totalWeekend - hometown;
            result = result * 2;
            result /= 3;
            result += (float)holidays / 2;
            result += hometown; 
            result += additionalPlays;

            Console.WriteLine((int)result);
        }
        else if (isLeapYear == "f")
        {
            // not leap year
            result = totalWeekend - hometown;
            result = result * 2;
            result /= 3;
            result += (float)holidays / 2;
            result += hometown;

            Console.WriteLine((int)result);
        }
    }
}