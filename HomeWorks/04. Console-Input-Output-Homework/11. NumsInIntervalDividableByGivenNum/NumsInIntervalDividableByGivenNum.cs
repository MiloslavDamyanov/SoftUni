using System;

class NumsInIntervalDividableByGivenNum
{
    static void Main()
    {
        Console.Write("Start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("End: ");
        int end = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                count++;
                // Console.Write("{0} ",i);                
            }
        }

        Console.WriteLine("\n{0}", count);
    }
}