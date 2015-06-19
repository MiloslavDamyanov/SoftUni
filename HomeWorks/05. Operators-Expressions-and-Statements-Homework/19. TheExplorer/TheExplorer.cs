using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dashCount = n / 2;
        string top = (new string('-', dashCount) + "*" + new string('-', dashCount));
        string botton = top;

        Console.WriteLine(top);
        for (int topIndex = 0; topIndex <= n - 2; topIndex++)
        {
            --dashCount;
            Console.WriteLine(new string('-', dashCount) + "*" + new string('-', 1 + topIndex) + "*" + new string('-', dashCount));
            topIndex++;
        }

        for (int bottonIndex = n - 2; bottonIndex > 1; bottonIndex--)
        {
            ++dashCount;
            Console.WriteLine(new string('-', dashCount) + "*" + new string('-', bottonIndex - 2) + "*" + new string('-', dashCount));
            bottonIndex--;
        }

        Console.WriteLine(botton);
    }
}
