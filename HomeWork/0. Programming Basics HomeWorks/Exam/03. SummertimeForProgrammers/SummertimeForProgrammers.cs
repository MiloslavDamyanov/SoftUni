using System;
using System.Collections.Generic;
using System.Linq;

class SummertimeForProgrammers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int widthBotton = 2 * n;
        int widthTop = n + 1;

        int height = 3 * n + 1;
        string topBottle = new string(' ', (widthBotton - widthTop) / 2) + new string('*', widthTop) + new string(' ', (widthBotton - widthTop) / 2);
        string bottomBottle = new string('*', n * 2);
        Console.WriteLine(topBottle);

        for (int i = 0; i <= (widthBotton - widthTop) / 2; i++)
        {
            Console.WriteLine(new string(' ', (widthBotton - widthTop) / 2) + "*" + new string(' ', widthTop - 2) + "*" + new string(' ', (widthBotton - widthTop) / 2));
        }

        int count = 1;
        int middleCount = widthTop;
        for (int i = 0; i < (((widthBotton - widthTop) / 2) - 1); i++)
        {
            Console.WriteLine(new string(' ', ((widthBotton - widthTop) / 2) - count) + "*" + new string(' ', middleCount) + "*" + new string(' ', ((widthBotton - widthTop) / 2) - count));
            count++;
            middleCount += 2;

        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*" + new string('.', (2 * n) - 2) + "*");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*" + new string('@', (2 * n) - 2) + "*");
        }

        Console.WriteLine(bottomBottle);
    }
}