using System;
using System.Collections.Generic;
using System.Text;

class BinToDec
{
    static void Main()
    {
        string input = Console.ReadLine();
        long dec = 0;
        List<string> binary = new List<string>();

        for (int i = 0; i < input.Length; i++)
        {
            binary.Add(input[i].ToString());
        }

        binary.Reverse();
        long pow = 1;

        for (int i = 0; i < binary.Count; i++)
        {
            if ((int)Math.Pow(double.Parse(binary[i]), pow) == 1)
            {
                dec += pow;
            }

            pow *= 2;
        }

        Console.WriteLine(dec);
    }
}