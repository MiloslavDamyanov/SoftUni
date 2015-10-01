using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        var str = input.ToList();
        str.Reverse();
        string reversed = string.Join("", str);
        Console.WriteLine(reversed);
    }
}