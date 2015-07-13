using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intNum = null;
        double? doubleNum = null;

        intNum = 1234;
        doubleNum = 3.1459;
        Console.WriteLine("int: {0}\ndouble: {1}", intNum, doubleNum);
    }
}