using System;
using System.Collections.Generic;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("First date: ");
        var firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Second date: ");
        var secondDate = DateTime.Parse(Console.ReadLine());
        var result = secondDate - firstDate;
        Console.WriteLine(result.Days);
    }
}
