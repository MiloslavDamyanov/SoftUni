using System;

class QuotesInStrings
{
    static void Main()
    {
        string stringOne = "The \"use\" of quotations causes difficulties.";
        string stringTwo = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("{0}\n{1}", stringOne, stringTwo);
    }
}