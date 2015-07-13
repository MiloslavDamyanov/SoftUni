using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int countOfNums = n * 2;
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 0; i < countOfNums; i++)
        {

            if (i % 2 != 0)
            {
                oddSum += int.Parse(Console.ReadLine());
            }
            else if (i % 2 == 0)
            {
                evenSum += int.Parse(Console.ReadLine());
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
        }
    }
}