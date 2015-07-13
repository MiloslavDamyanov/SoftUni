using System;

class Headphones
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int verticalLength = (n * 2) + 1;
        int dashCount = (verticalLength - (n + 2)) / 2;
        string top = string.Format(new string('-', dashCount) + "*" + new string('*', n) + "*" + new string('-', dashCount));
        string middle = string.Format(new string('-', dashCount) + "*" + new string('-', n) + "*" + new string('-', dashCount));

        Console.WriteLine(top);
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(middle);
        }

        int countAsterisk = 1;
        int centerDash = n;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('-', dashCount) + new string('*', countAsterisk) + new string('-', centerDash) + new string('*', countAsterisk) + new string('-', dashCount));
            dashCount--; ;
            centerDash -= 2;
            countAsterisk += 2;
        }

        for (int i = 0; i <= n / 2; i++)
        {
            Console.WriteLine(new string('-', dashCount) + new string('*', countAsterisk) + new string('-', centerDash) + new string('*', countAsterisk) + new string('-', dashCount));
            dashCount++; ;
            centerDash += 2;
            countAsterisk -= 2;
        }
    }
}