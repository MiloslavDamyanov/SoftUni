using System;

class NumsFromOneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;

        while (counter != n)
        {
            Console.Write("{0} ", ++counter);
        }

        Console.WriteLine();
    }
}