using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char copyrightSymbol = '©';
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("   {0}   ", copyrightSymbol);
        Console.WriteLine("  {0} {0}  ", copyrightSymbol);
        Console.WriteLine(" {0}   {0} ", copyrightSymbol);
        Console.WriteLine("{0} {0} {0} {0}  ", copyrightSymbol);

        // Console setting must be Font Lucida Console or Consolas
    }
}
