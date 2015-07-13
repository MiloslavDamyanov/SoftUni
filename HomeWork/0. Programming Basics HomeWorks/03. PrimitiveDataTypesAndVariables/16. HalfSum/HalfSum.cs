using System;

class HalfSum
{
    static void Main()
    {
        int countOfNumbers = int.Parse(Console.ReadLine());
        int[] arr = new int[countOfNumbers * 2];
        int firstSum = 0;
        int secondSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (i < countOfNumbers)
            {
                firstSum += arr[i];
            }

            else if (i >= countOfNumbers)
            {
                secondSum += arr[i];
            }
        }

        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum={0}", firstSum);
        }
        else if (firstSum != secondSum)
        {
            if (firstSum > secondSum)
            {
                Console.WriteLine("No, diff={0}", firstSum - secondSum);
            }
            else if (secondSum > firstSum)
            {
                Console.WriteLine("No, diff={0}", secondSum - firstSum);
            }
        }
    }
}