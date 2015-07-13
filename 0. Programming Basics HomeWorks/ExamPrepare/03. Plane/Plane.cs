using System;
using System.Collections.Generic;

class Plane
{
    static void Main()
    {
        int n = 9;

        int planeHeight = (n * 3) - (n / 2);
        int dotCount = n + (n / 2);
        int planeWidth = n * 3;
        string top = string.Format(new string('.', dotCount) + "*" + new string('.', dotCount));
        Console.WriteLine(top);
        int count = 1;
        int length = 0;
        if (n == 5)
        {
            length = n - 1;
        }
        else
        {
            length = n - 2;
        }
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(new string('.', dotCount - 1) + "*" + new string('.', count) + "*" + new string('.', dotCount - 1));
            dotCount -= 1;
            count += 2;
        }



    }
}