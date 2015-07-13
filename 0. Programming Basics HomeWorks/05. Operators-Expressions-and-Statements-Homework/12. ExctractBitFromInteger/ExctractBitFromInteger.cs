using System;

class ExctractBitFromInteger
{
    static void Main()
    {
        Console.Write("Number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Position: ");
        int position = int.Parse(Console.ReadLine()); ;

        int result = number >> position;
        int bit = result & 1;
        // Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
        Console.WriteLine(bit);
    }
}