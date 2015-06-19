using System;
using System.Collections.Generic;
using System.Linq;

class Pairs
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] separator = { ' ' };
        string[] strArray = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        int[] array = new int[strArray.Length];
        List<int> values = new List<int>();
        string result = null;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(strArray[i]);
            if (i % 2 != 0)
            {
                values.Add(array[i - 1] + array[i]);
            }
        }

        int? areEqual = null;
        int toCompare = values[0];
        int maxdiff = 0;
        int index = 0;
        var temp = new List<int>();
        for (int i = 0; i < values.Count; i++)
        {
            if (areEqual == 0)
            {
                if (index < values.Count - 1)
                {
                    index++;
                    maxdiff = Math.Abs(values[i] - values[index]);
                    temp.Add(maxdiff);
                }
                else
                {
                    index = 0;
                    if (index < temp.Count - 1)
                    {
                        index++;
                        for (int j = 0; j < temp.Count; j++)
                        {
                            maxdiff = Math.Abs(temp[j] - temp[index]);
                        }
                    }
                }

                result = "No, maxdiff=" + maxdiff;
            }
            else
            {
                if (toCompare == values[i])
                {
                    if (areEqual == null)
                    {
                        areEqual = 0;
                    }

                    areEqual++;
                }
                else if (toCompare != values[i])
                {
                    areEqual = 0;
                    i = -1;
                }

                if (areEqual == values.Count)
                {
                    result = "Yes, value=" + values[i];
                }
            }
        }

        Console.WriteLine(result);
    }
}