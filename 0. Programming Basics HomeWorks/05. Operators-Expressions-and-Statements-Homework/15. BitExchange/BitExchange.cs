using System;

class BitExchange
{
    static void Main()
    {

        int i = 3;
        int j = 24;   // i ,j positions of bit sequences to swap
        int sequenceOfBits = 3;    // number of consecutive bits in each sequence
        uint number = uint.Parse(Console.ReadLine());    // bits to swap reside in b
        long result = 0;    // bit-swapped result goes here

        long x = ((number >> i) ^ (number >> j)) & ((1 << sequenceOfBits) - 1); // XOR temporary
        result = number ^ ((x << i) | (x << j));
        Console.WriteLine(result);

    }
}