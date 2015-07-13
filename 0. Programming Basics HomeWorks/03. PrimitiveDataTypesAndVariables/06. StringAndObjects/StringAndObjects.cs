using System;

class StringAndObjects
{
    static void Main()
    {
        string stringHi = "Hello";
        string stringWorld = "World";
        string space = " ";

        object concatenated = stringHi + space + stringWorld;
        Console.WriteLine(concatenated);
    }
}
