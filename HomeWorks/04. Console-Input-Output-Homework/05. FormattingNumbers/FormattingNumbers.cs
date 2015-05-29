using System;
using System.Threading;
using System.Globalization;

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string strAValue = string.Format(Convert.ToString(a, 16).ToUpper().PadRight(10, ' '));
        string strAValueToBin = string.Format(Convert.ToString(a, 2).PadLeft(10, '0'));
        string strBValue = string.Format("{0:F2}".PadLeft(11, ' '), b);
        string strCvalue = string.Format("{0:F3}".PadRight(11, ' '), c);

        Console.WriteLine("|{0}|{1}|{2}|{3}|", strAValue, strAValueToBin, strBValue, strCvalue);
    }
}
