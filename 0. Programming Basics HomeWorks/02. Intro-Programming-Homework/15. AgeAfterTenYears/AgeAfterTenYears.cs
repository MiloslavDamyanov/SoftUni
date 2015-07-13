using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Please enter your birthday!\nYear: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Day: ");
        int day = int.Parse(Console.ReadLine());

        DateTime birthday = new DateTime(year, month, day);
        int currentAge = DateTime.Now.Year - birthday.Year;

        Console.WriteLine("Now you are {0} years old, afeter 10 years you will be {1}", currentAge, currentAge + 10);
    }
}
