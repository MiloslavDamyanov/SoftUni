using System;
using System.Collections.Generic;
using System.Linq;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> elements = new List<string>();
        int countOfEqualElements = 0;

        for (int i = 0; i < n; i++)
        {
            elements.Add(Console.ReadLine());
        }

        string element = elements[0];
        int max = 0;
        int maxLength = 0;
        int indexOfMaxElement = 0;
        int currentIndexOfMaxEl = 0;
        int currentMaxLength = 0;

        for (int i = 0; i < elements.Count; i++)
        {
            if (element == elements[i])
            {
                countOfEqualElements++;
            }
            else
            {
                max = countOfEqualElements;
                if (max > maxLength)
                {
                    maxLength = max;
                }

                element = elements[i];
                indexOfMaxElement = i;
                countOfEqualElements = 1;
            }
        }

        Console.WriteLine(countOfEqualElements);
        for (int i = indexOfMaxElement; i < indexOfMaxElement + countOfEqualElements; i++)
        {
            Console.WriteLine(elements[i]);
        }
    }
}
