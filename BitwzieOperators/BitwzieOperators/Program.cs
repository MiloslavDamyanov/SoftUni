using System;
class Program
{
    static void Main()
    {
        // get the bit at position p from a number n?
        int position = 5;
        int number = 291;                   // 00000001 00100011
        int nRightP = number >> position;   // 00000000 00001001
        int bit = nRightP & 1;              // 00000000 00000001
        Console.WriteLine(bit);             // 1

        // set the bit at position p to 0
        position = 5;
        number = 291;                       // 00000001 00100011
        int mask = ~(1 << position);        // 11111111 11011111
        int result = number & mask;         // 00000001 00000011
        Console.WriteLine(result);          // 259

        // set the bit at position p to 1
        position = 4;
        number = 291;                       // 00000001 00100011
        mask = 1 << position;               // 00000000 00010000
        result = number | mask;             // 00000001 00110011
        Console.WriteLine(result);          // 307



    }
}