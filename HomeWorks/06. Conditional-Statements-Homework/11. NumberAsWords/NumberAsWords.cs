using System;

class NumberAsWords
{
    static void Main()
    {
        string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string result = "";

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 99)
        {
            result += ones[number / 100] + " hundred";
            number %= 100;

            if (number != 0)
            {
                result += " and ";
            }
        }

        if (number > 19)
        {
            result += tens[number / 10 - 2];
            number %= 10;

            if (number != 0)
            {
                result += " ";
            }
        }

        result += ones[number];
        Console.WriteLine(result);
    }
}