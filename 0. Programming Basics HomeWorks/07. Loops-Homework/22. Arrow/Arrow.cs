using System;
using System.Collections.Generic;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotCount = (n - 1) / 2;
        string top = string.Format(new string('.', dotCount) + new string('#', n) + new string('.', dotCount));
        string middle = string.Format(new string('.', dotCount) + "#" + new string('.', n - 2) + "#" + new string('.', dotCount));
        string botton = string.Format(new string('#', dotCount + 1) + new string('.', n - 2) + new string('#', dotCount + 1));       

        Console.WriteLine(top);
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(middle);
        }

        Console.WriteLine(botton);
        List<int> array = new List<int>();
        List<int> arr = new List<int>() { 3, 2, 1 };
        int num = 0;

        for (int i = 3; i < 80; i++)
        {
            if (i % 2 != 0)
            {
                array.Add(i);
            }

            if (i < 39)
            {
                arr.Add(-(i - 3));
            }
        }

        for (int i = 0; i < array.Count; i++)
        {
            if (n == array[i])
            {
                num = arr[i];
                break;
            }
        }

        int arrowDotCount = (n + dotCount) - num;
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(new string('.', i + 1) + "#" + new string('.', arrowDotCount) + "#" + new string('.', i + 1));
            arrowDotCount -= 2;
        }

        dotCount = n - 1;
        string bottonArrow = string.Format(new string('.', dotCount) + "#" + new string('.', dotCount));
        Console.WriteLine(bottonArrow);
    }
}