using System;
using System.Collections.Generic;

class DecToHex
{
    static void Main()
    {
        int dec = int.Parse(Console.ReadLine());
        string[] hexArr = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        List<int> list = new List<int>();
        int result = 0;
        while (dec != 0)
        {
            result = dec % 16;
            dec /= 16;
            list.Add(result);
        }

        list.Reverse();
        string hex = null;
        for (int i = 0; i < list.Count; i++)
        {
            hex += hexArr[list[i]];
        }

        Console.WriteLine(hex);
    }
}