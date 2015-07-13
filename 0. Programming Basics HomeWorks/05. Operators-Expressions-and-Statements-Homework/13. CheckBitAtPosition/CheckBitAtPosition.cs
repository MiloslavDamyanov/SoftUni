using System;
class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Position: ");
        int position = int.Parse(Console.ReadLine()); ;

        int result = number >> position;
        int bit = result & 1;

        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}