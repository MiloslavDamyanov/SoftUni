using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

class GenericArraySort
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        string[] strings = { "zaz", "cba", "baa", "azis" };
        DateTime[] dates = { new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1) };

        // BubbleSort
        SortArray(numbers);
        SortArray(strings);
        SortArray(dates);

        // Print Sorted Array
        Print(numbers);
        Print(strings);
        Print(dates);
    }

    private static void Print<T>(T[] arraDates)
    {
        string sortedValues = string.Join(", ", arraDates);
        Console.WriteLine(sortedValues);
    }


    public static void SortArray<T>(T[] numbersList) where T : IComparable   // T is type that you can Compare
    {
        bool isSorted = false;
        int CountOfSortedNums = 0;

        while (!isSorted)
        {
            for (int currentIndex = 0, nextIndex = 1; currentIndex < numbersList.Length; currentIndex++, nextIndex++)
            {
                if (currentIndex < numbersList.Length - 1)
                {
                    int comparedValues = numbersList[currentIndex].CompareTo(numbersList[nextIndex]);

                    if (comparedValues != -1 && comparedValues != 0)
                    {
                        SwappingValues(numbersList, currentIndex, nextIndex);
                        CountOfSortedNums = 0;
                    }
                    else if (comparedValues == -1)
                    {
                        CountOfSortedNums++;

                        if (CountOfSortedNums == numbersList.Length - 1)
                        {
                            isSorted = true;
                        }
                    }
                }
            }
        }
    }

    private static void SwappingValues<T>(T[] numbers, int currentIndex, int nextIndex)
    {
        dynamic value = 0;
        value = numbers[currentIndex];
        numbers[currentIndex] = numbers[nextIndex];
        numbers[nextIndex] = value;
    }

}
