using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SortArrayOfNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        var array = ToArray(input);
        Sort(array);

        string result = string.Join(" ", array);
        Console.WriteLine(result);
    }

    private static void Sort(int[] array)
    {

        int countOfSortedElements = 0;
        int index = 0;
        int nextIndex = 1;
        int value = 0;
        while (countOfSortedElements != array.Length)
        {
            if (array[index] > array[nextIndex])
            {
                value = array[index];
                array[index] = array[nextIndex];
                array[nextIndex] = value;
                countOfSortedElements = 0;
            }

            if (nextIndex < array.Length - 1 && index < array.Length - 2)
            {
                nextIndex++;
                index++;
            }
            else
            {
                index = 0;
                nextIndex = 1;
            }

            countOfSortedElements++;
        }
    }

    private static int[] ToArray(string input)
    {
        var array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[array.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(array[i]);
        }

        return numbers;
    }
}