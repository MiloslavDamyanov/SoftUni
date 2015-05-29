using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        // without uisng temp variable exchange with XOR ^=
        Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
        a ^= b;
        b ^= a;
        a ^= b;
        Console.WriteLine("After:\na = {0}\nb = {1}", a, b);

        //// Using temp variable. To work correctly comment XOR

        //int temp = 0;
        //temp = a;
        //a = b;
        //b = temp;
        //Console.WriteLine("After exchange: a = {0}, b = {1}", a, b);
    }
}
