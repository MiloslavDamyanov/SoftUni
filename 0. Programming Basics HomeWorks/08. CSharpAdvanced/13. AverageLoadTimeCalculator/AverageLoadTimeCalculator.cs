using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        List<string> list = new List<string>();
        var dictionary = new Dictionary<string, double>();
        var set = new HashSet<string>();
        AddLinesToList(list);
        CalcAverageTime(list, dictionary);
        PrintResult(list, dictionary, set);

    }

    private static void PrintResult(List<string> list, Dictionary<string, double> dictionary, HashSet<string> set)
    {
        foreach (var key in dictionary)
        {
            set.Add(key.Key);
        }

        list = set.ToList();
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < dictionary.Count; j++)
            {
                if (dictionary.ContainsKey(list[i]))
                {
                    Console.WriteLine("{0} {1} ", list[i], dictionary[list[i]]);
                    break;
                }
            }
        }
    }



    private static void CalcAverageTime(List<string> list, Dictionary<string, double> dictionary)
    {
        char[] seaparator = { ' ' };
        var average = new List<double>();
        var newList = new List<string>(list);
        newList.Sort();



        var url = newList[0].Split(seaparator, StringSplitOptions.RemoveEmptyEntries).ToList();
        double count = 0;
        double sum = 0;
        for (int i = 0; i < newList.Count; i++)
        {
            while (newList[i].Contains(url[0]))
            {
                url = newList[i].Split(seaparator, StringSplitOptions.RemoveEmptyEntries).ToList();
                count++;
                sum += double.Parse(url[1]);
                if (i < newList.Count - 1)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }

            if (i < newList.Count - 1)
            {
                url = newList[i].Split(seaparator, StringSplitOptions.RemoveEmptyEntries).ToList();
                --i;
                average.Add(sum / count);
                sum = 0;
                count = 0;
            }
            else
            {
                average.Add(sum / count);
                break;
            }
        }


        var temp = newList[0].Split(seaparator, StringSplitOptions.RemoveEmptyEntries).ToList();
        int index = 0;
        dictionary.Add(temp[0], average[index]);
        string strTemp = temp[0];

        for (int i = 0; i < newList.Count; i++)
        {
            temp = newList[i].Split(seaparator, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (temp[0] != strTemp)
            {
                index++;
                dictionary.Add(temp[0], average[index]);
                strTemp = temp[0];
            }
        }
    }

    private static void AddLinesToList(List<string> list)
    {
        string input = null;
        char[] seaparator = { ' ' };
        while (input != string.Empty)
        {
            input = Console.ReadLine();
            if (input != string.Empty)
            {
                var temp = input.Split(seaparator, StringSplitOptions.RemoveEmptyEntries);
                list.Add(temp[2] + " " + temp[3]);
            }
        }
    }
}