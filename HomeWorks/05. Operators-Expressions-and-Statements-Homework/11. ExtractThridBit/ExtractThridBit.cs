using System;

class ExtractThridBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = 3;
        int result = number >> position;
        int bit = result & 1;
        // Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
        Console.WriteLine(bit);
    }
}