﻿using System;
using System.Globalization;
using System.Threading;

class NumsWithNestedIfs
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        if ((a > b && b > c) || (a == b && b == c))
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
        else if (a > b && c > b && a > c)
        {
            Console.WriteLine("{0} {1} {2}", a, c, b);
        }
        else if ((b > a && a > c) || (a == b && c < a))
        {
            Console.WriteLine("{0} {1} {2}", b, a, c);
        }

        else if (b > a && c > a && b > c)
        {
            Console.WriteLine("{0} {1} {2}", b, c, a);
        }
        else if (c > a && c > b && a > b)
        {
            Console.WriteLine("{0} {1} {2}", c, a, b);
        }
        else if (c > a && c > b && b > a)
        {
            Console.WriteLine("{0} {1} {2}", c, b, a);
        }
        else if (a < b && b > c && a == c)
        {
            Console.WriteLine("{0} {1} {2}", b, a, c);
        }
        else if (a == b && b > c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
        else if (a == b && b < c)
        {
            Console.WriteLine("{0} {1} {2}", c, a, b);
        }
        else if (a == c && b < c)
        {
            Console.WriteLine("{0} {1} {2}", a, c, b);
        }
        else if (b == c && b > a)
        {
            Console.WriteLine("{0} {1} {2}", b, c, a);
        }
        else if (b == c && b < a)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }


    }
}