using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] symbols = new int[255];

        for (int i = 0; i < input.Length; i++)
        {
            symbols[input[i]]++;
        }

        for (int i = 0; i < symbols.Length; i++)
        {
            if (symbols[i] != 0)
            {
                Console.WriteLine("{0}: {1} time/s", (char)i, symbols[i]);
            }
        }
    }
}
