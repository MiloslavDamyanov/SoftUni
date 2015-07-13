using System;
using System.Collections.Generic;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // 3,5,7,9,11... 101
        List<string> list = new List<string>();

        string top = string.Format(new string('*', n) + new string('*', n));
        list.Add(top);

        string middle = string.Format(new string('*', n - (n - 1)) + new string('/', (n - 1) * 2) + new string('*', n - (n - 1)));

        for (int i = 0; i < n - 2; i++)
        {
            list.Add(middle);
        }

        string botton = string.Format(new string('*', n) + new string('*', n));
        list.Add(botton);

        for (int i = 0; i < list.Count; i++)
        {
            if (i != n / 2)
            {
                Console.WriteLine(list[i] + new string(' ', n) + list[i]);
            }
            else
            {
                Console.WriteLine(list[i] + new string('|', n) + list[i]);
            }
        }
    }
}