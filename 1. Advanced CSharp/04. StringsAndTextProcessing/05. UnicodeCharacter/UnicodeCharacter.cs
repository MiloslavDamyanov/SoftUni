using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UnicodeCharacter
{
    static void Main()
    {
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("\\u{0:x4}", Convert.ToUInt16(input[i]));
        }

        Console.WriteLine();
    }
}
