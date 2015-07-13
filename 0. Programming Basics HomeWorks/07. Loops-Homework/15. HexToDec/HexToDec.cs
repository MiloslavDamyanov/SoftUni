using System;
using System.Collections.Generic;

class HexToDec
{
    static void Main()
    {
        string hexInput = Console.ReadLine().ToUpper();
        string[] hex = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        List<string> hexList = new List<string>();
        for (int i = 0; i < hexInput.Length; i++)
        {
            hexList.Add(hexInput[i].ToString());
        }

        hexList.Reverse();
        int pow = 1;
        long dec = 0;
        for (int i = 0; i < hexList.Count; i++)
        {
            for (int index = 0; index < hex.Length; index++)
            {
                if (hexList[i] == hex[index])
                {
                    dec += index * pow;
                    pow *= 16;
                }
            }
        }

        Console.WriteLine(dec);
    }
}