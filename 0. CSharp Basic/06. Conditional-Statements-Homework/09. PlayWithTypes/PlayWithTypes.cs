using System;
using System.Threading;
using System.Globalization;

class PlayWithTypes
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int choice = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (choice)
        {
            case 1:
                Console.Write("Please enter a int: ");
                Console.WriteLine(int.Parse(Console.ReadLine()) + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                Console.WriteLine(double.Parse(Console.ReadLine()) + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                Console.WriteLine(Console.ReadLine() + "*");
                break;
            default:
                Console.WriteLine("Wrong choice!");
                break;
        }
    }
}
