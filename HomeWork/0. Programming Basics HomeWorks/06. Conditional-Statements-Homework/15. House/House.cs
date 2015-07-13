using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotsCount = n / 2;
        string topRoof = (new string('.', dotsCount) + "*" + new string('.', dotsCount));
        string bottonRoof = new string('*', n);

        Console.WriteLine(topRoof);

        for (int topIndex = 0; topIndex < n - 3; topIndex++)
        {
            --dotsCount;
            Console.WriteLine(new string('.', dotsCount) + "*" + new string('.', 1 + topIndex) + "*" + new string('.', dotsCount));
            topIndex++;
        }

        Console.WriteLine(bottonRoof);

        int countDots = (int)(n / 2) / 2;
        int countAsterisk = n - ((countDots + 1) * 2);
        for (int rows = 0; rows < n / 2; rows++)
        {

            if (rows == (n / 2) - 1)
            {
                Console.WriteLine(new string('.', countDots) + "*" + new string('*', countAsterisk) + "*" + new string('.', countDots));
            }
            else
            {
                Console.WriteLine(new string('.', countDots) + "*" + new string('.', countAsterisk) + "*" + new string('.', countDots));
            }
        }
    }
}