using System;

class WorkHours
{
    static void Main()
    {
        long hours = long.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int productivityPercent = int.Parse(Console.ReadLine());
        int bikingPercent = 10;
        double workDays = days - ((double)bikingPercent / 100) * days;

        double workHours = (double)workDays * 12;
        int moreHours = (int)(((double)productivityPercent / 100) * workHours);

        long result = moreHours - hours;
        if (result >= 0)
        {
            Console.WriteLine("Yes\n{0}", result);
        }
        else if (result < 0)
        {
            Console.WriteLine("No\n{0}", result);
        }
    }
}