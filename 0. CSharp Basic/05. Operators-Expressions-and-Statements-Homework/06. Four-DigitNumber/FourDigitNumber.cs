using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter four digit number: ");
        string input = Console.ReadLine();
        int sum = 0;
        string reversedString = string.Empty;
        string lastDigitInFront = string.Empty;
        string exchangedDigits = string.Empty;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            sum += int.Parse(input[i].ToString());

            reversedString += input[i];
        }

        int num = int.Parse(input);
        int lastDigit = num % 10;
        num /= 10;
        lastDigitInFront = string.Format("{0}{1}", lastDigit, num);

        exchangedDigits = string.Format("{0}{1}{2}{3}", input[0], input[2], input[1], input[3]);

        Console.WriteLine(sum);
        Console.WriteLine(reversedString);
        Console.WriteLine(lastDigitInFront);
        Console.WriteLine(exchangedDigits);
    }



}