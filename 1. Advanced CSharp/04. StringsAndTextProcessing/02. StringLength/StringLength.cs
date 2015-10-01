using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input.Length < 20)
        {
            input = input + new string('*', 20 - input.Length);
        }
        else if (input.Length > 20)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 20; i++)
            {
                sb.Append(input[i]);
            }

            input = sb.ToString();
        }

        Console.WriteLine(input);
    }
}