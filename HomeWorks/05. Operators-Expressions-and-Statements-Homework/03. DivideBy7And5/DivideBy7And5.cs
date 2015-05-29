using System;

class DivideBy7And5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isDevided = true;

        if (number % 7 == 0 && number % 5 == 0 && number != 0)
        {
            Console.WriteLine(isDevided);
        }
        else
        {
            Console.WriteLine(!isDevided);
        }
    }
}
