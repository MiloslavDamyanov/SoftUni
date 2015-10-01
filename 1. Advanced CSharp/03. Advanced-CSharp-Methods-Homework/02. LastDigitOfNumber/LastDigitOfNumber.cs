using System;
using System.Collections.Generic;

class LastDigitOfNumber
{
    static void Main()
    {
        Console.WriteLine(GetLastDigitAsWord(512));
        Console.WriteLine(GetLastDigitAsWord(1024));
        Console.WriteLine(GetLastDigitAsWord(12309));
    }

    private static string GetLastDigitAsWord(int number)
    {
        string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int lastDisigt = number % 10;

        return words[lastDisigt];
    }
}