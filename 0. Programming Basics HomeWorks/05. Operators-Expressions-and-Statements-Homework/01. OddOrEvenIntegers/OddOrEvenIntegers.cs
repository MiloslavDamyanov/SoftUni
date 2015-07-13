using System;
class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isOdd = true;

        if (n % 2 == 0)
        {
            Console.WriteLine(!isOdd);
        }
        else if (n % 2 != 0)
        {
            Console.WriteLine(isOdd);
        }
    }
}
