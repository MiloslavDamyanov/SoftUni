using System;
class ModifyBitAtPosition
{
    static void Main()
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Value: ");
        int value = int.Parse(Console.ReadLine());

        int mask = 0;
        int result = 0;

        if (value == 0)
        {
            mask = ~(1 << position);
            result = number & mask;
        }
        else if (value == 1)
        {
            mask = 1 << position;
            result = number | mask;
        }

        Console.WriteLine(result);
    }
}
