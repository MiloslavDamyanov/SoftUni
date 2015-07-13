using System;
using System.Collections.Generic;
using System.Linq;

class OddOrEvenCounter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string oddOrEven = Console.ReadLine();

        int length = n * c;
        List<long> numbers = new List<long>();

        for (int i = 0; i < length; i++)
        {
            numbers.Add(long.Parse(Console.ReadLine()));
        }

        int count = 0;
        int index = 0;
        List<int> countOfnumbers = new List<int>();
        for (int i = 0; i < length; i++)
        {
            if (oddOrEven == "odd")
            {
                if (numbers[i] % 2 != 0)
                {
                    count++;
                }
            }
            else if (oddOrEven == "even")
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }

            index++;
            if (index == c)
            {
                countOfnumbers.Add(count);
                count = 0;
                index = 0;
            }
        }

        string[] word = new string[] { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };
        string result = null;
        int countZeros = 0;

        for (int i = 0; i < countOfnumbers.Count; i++)
        {
            if (countOfnumbers[i] == 0)
            {
                countZeros++;
            }
        }

        int maxElement = countOfnumbers.Max();
        for (int i = 0; i < countOfnumbers.Count; i++)
        {
            if (countOfnumbers[i] == maxElement)
            {
                index = i;
                break;
            }
        }

        if (countZeros == countOfnumbers.Count)
        {
            result = "No";
        }
        else
        {
            result = string.Format("{0} set has the most {1} numbers: {2}", word[index], oddOrEven, countOfnumbers[index]);
        }

        Console.WriteLine(result);
    }
}
