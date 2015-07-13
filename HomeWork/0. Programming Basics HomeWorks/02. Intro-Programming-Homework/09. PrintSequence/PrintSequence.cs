using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(" {0}", i);
            }
            else if (i % 2 != 0)
            {
                Console.WriteLine(-i);
            }
        }
    }
}