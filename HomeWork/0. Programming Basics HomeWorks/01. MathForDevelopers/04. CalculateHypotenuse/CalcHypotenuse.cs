namespace _04. CalculateHypotenuse
{
    using System;

    public class CalcHypotenuse
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double hypotenuse = 0;

            hypotenuse = Math.Sqrt(a * a + b * b);
            Console.WriteLine("{0:F2}", hypotenuse);
        }
    }
}