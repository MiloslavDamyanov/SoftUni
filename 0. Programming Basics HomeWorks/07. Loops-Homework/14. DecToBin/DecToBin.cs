using System;
using System.Collections.Generic;

class DecToBin
{
    static void Main()
    {
        int dec = int.Parse(Console.ReadLine());
        int result = dec;
        List<int> binary = new List<int>();

        while (dec != 0)
        {
            result = dec % 2;
            dec /= 2;
            binary.Add(result);
        }

        binary.Reverse();
        for (int i = 0; i < binary.Count; i++)
        {
            Console.Write(binary[i]);
        }

        Console.WriteLine();
    }
}
