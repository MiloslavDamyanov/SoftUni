using System;

class OddEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] seaparator = new char[] { ' ' };
        string[] arr = input.Split(seaparator, StringSplitOptions.RemoveEmptyEntries);
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 != 0)
            {
                oddProduct *= int.Parse(arr[i]);
            }
            else if (i % 2 == 0)
            {
                evenProduct *= int.Parse(arr[i]);
            }
        }

        Console.WriteLine(oddProduct == evenProduct ? "yes\nproduct = " + oddProduct : "no\nodd_product = " + oddProduct + "\neven_product = " + evenProduct);
    }
}
