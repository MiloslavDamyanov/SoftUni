using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int center = n - (((int)n / 2) * 2);
        int sides = (int)(n / 2);
        int roofHeight = (int)((n + 1) / 2);

        for (int i = 0; i < roofHeight; i++)
        {
            Console.WriteLine(new string('-', sides - i) + new string('*', center + i + i) + new string('-', sides - i));
        }

        string houseBody = string.Format("|" + new string('*', n - 2) + "|");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(houseBody);
        }
    }
}