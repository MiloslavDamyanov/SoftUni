using System;
using System.Globalization;

class ExamSchedule
{
    static void Main()
    {

        DateTime time = new DateTime();
        DateTime durationTime = new DateTime();
        string timeResult = null;
        string hours = Console.ReadLine();
        string minutes = Console.ReadLine();
        string partOfDay = Console.ReadLine().ToUpper();

        string durationHours = Console.ReadLine();
        string durationMinutes = Console.ReadLine();
        string duration = durationHours + ":" + durationMinutes;
        durationTime = DateTime.Parse(duration);

        timeResult = string.Format(hours + ":" + minutes + " " + partOfDay);
        time = DateTime.Parse(timeResult);
        var result = time.TimeOfDay + durationTime.TimeOfDay;

        DateTime newTme = new DateTime(1, 1, 1, result.Hours, result.Minutes, 0);
        Console.WriteLine(newTme.ToString("hh:mm:tt", CultureInfo.InvariantCulture));
    }
}