using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LettersChangeNumbers
{
    static void Main()
    {
        var capitalLetters = new List<char>();
        var lowerLetters = new List<char>();

        GetLetters(capitalLetters, lowerLetters);

        string input = Console.ReadLine();

        var values = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        double result = 0;
        double number = 0;

        string temp = string.Empty;
        for (int i = 0; i < values.Count; i++)
        {
            for (int index = 1; index < values[i].Length - 1; index++)
            {
                temp += values[i][index];
            }
            number = int.Parse(temp);
            temp = null;

            // before number
            if (values[i][0] >= 65 && values[i][0] <= 90) // Capital
            {
                number /= capitalLetters.IndexOf(values[i][0]) + 1;
            }
            else if (values[i][0] >= 97 && values[i][0] <= 122)
            {
                number *= lowerLetters.IndexOf(values[i][0]) + 1;
            }

            // after number
            if (values[i][values[i].Length - 1] >= 65 && values[i][values[i].Length - 1] <= 90) // Capital
            {
                number -= capitalLetters.IndexOf(values[i][values[i].Length - 1]) + 1;

            }
            else if (values[i][values[i].Length - 1] >= 97 && values[i][values[i].Length - 1] <= 122)
            {
                number += lowerLetters.IndexOf(values[i][values[i].Length - 1]) + 1;
            }

            result += number;
        }

        Console.WriteLine("{0:F2}", result);
    }

    private static void GetLetters(List<char> capitalLetters, List<char> lowerLetters)
    {
        for (int i = 0; i < 127; i++)
        {
            if (i >= 65 && i <= 90)
            {
                capitalLetters.Add((char)i);
            }

            if (i >= 97 && i <= 122)
            {
                lowerLetters.Add((char)i);
            }
        }
    }


}
