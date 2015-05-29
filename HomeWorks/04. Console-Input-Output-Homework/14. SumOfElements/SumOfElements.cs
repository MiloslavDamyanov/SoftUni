using System;

class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] symbol = new char[] { ' ' };
        string[] arr = input.Split(symbol, StringSplitOptions.RemoveEmptyEntries);
        int[] intArray = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            intArray[i] = int.Parse(arr[i]);
        }

        Array.Sort(intArray);
        long sum = 0;
        for (int i = 0; i < intArray.Length - 1; i++)
        {
            sum += intArray[i];
        }

        if (sum == intArray[intArray.Length - 1])
        {
            Console.WriteLine("Yes, sum={0}", sum);
        }
        else if (sum != intArray[intArray.Length - 1])
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sum - intArray[intArray.Length - 1]));
        }
    }
}