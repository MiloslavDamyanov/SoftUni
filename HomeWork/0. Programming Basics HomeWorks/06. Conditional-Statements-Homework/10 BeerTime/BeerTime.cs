using System;
class BeerTime
{
    static void Main()
    {
        Console.Write("Enter a time in format \"h:mm AM/PM\" - ");
        string inputTime = Console.ReadLine().ToUpper();
        try
        {
            DateTime time = DateTime.Parse(inputTime);
            DateTime from = DateTime.Parse("1:00 PM");
            DateTime to = DateTime.Parse("3:00 AM");

            if (time.TimeOfDay >= from.TimeOfDay && inputTime.Contains("PM") || time.TimeOfDay < to.TimeOfDay && inputTime.Contains("AM"))
            {
                Console.WriteLine("{0} - {1}", time.TimeOfDay, "beer time");
            }
            else
            {
                Console.WriteLine("{0} - {1}", time.TimeOfDay, "non-beer time");
            }
        }
        catch (FormatException)
        {

            Console.WriteLine("Invalid format!\nValid format is 11:25 AM / 05:32 PM");
        }
    }
}