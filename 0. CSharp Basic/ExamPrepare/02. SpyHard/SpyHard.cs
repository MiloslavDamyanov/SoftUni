using System;
using System.Collections.Generic;
using System.Linq;

class SpyHard
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        var ascii = new List<char>();
        var capitalLetters = new List<char>();
        var lowerLetters = new List<char>();
        var numbers = new List<int>();
        int sum = 0;

        AsciiTable(ascii, capitalLetters, lowerLetters);
        MessageToNumber(message, ascii, capitalLetters, lowerLetters, numbers);
        sum = numbers.Sum();
        var convertedNumber = ConvertNumbers(sum, key);
        Console.WriteLine(string.Format("{0}{1}{2}", key, message.Length, convertedNumber));
    }

    private static string ConvertNumbers(int number, int toBaseSystem)
    {
        int dec = number;
        int result = dec;
        List<int> binary = new List<int>();

        while (dec != 0)
        {
            result = dec % toBaseSystem;
            dec /= toBaseSystem;
            binary.Add(result);
        }

        binary.Reverse();
        string str = null;
        for (int i = 0; i < binary.Count; i++)
        {
            str += binary[i];
        }

        return str;
    }


    private static void MessageToNumber(string message, List<char> ascii, List<char> capitalLetters, List<char> lowerLetters, List<int> numbers)
    {
        for (int i = 0; i < message.Length; i++)
        {
            if (lowerLetters.Contains(message[i]))
            {
                numbers.Add(lowerLetters.IndexOf(message[i]) + 1);
            }
            else if (capitalLetters.Contains(message[i]))
            {
                numbers.Add(capitalLetters.IndexOf(message[i]) + 1);
            }
            else if (ascii.Contains(message[i]))
            {
                numbers.Add(ascii.IndexOf(message[i]));
            }
        }
    }

    private static void AsciiTable(List<char> ascii, List<char> capitalLetters, List<char> lowerLetters)
    {
        for (int i = 0; i < 128; i++)
        {
            ascii.Add((char)i);
            if (i >= 65 && i <= 90)
            {
                capitalLetters.Add((char)i);
            }
            else if (i >= 97 && i <= 122)
            {
                lowerLetters.Add((char)i);
            }
        }
    }
}
