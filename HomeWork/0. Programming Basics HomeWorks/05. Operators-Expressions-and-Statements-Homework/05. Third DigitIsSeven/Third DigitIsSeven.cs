using System;
using System.Text;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int x = 0;
        int count = 0;
        bool isSeven = true;

        if (input < 700)
        {
            Console.WriteLine(!isSeven);
        }
        else
        {
            while (count != 3)
            {
                x = input % 10;
                count++;
                input /= 10;
            }

            if (x == 7)
            {
                Console.WriteLine(isSeven);
            }
            else
            {
                Console.WriteLine(!isSeven);
            }
        }
    }
}