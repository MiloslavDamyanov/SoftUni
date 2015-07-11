using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PetarsGame
{
    static void Main()
    {
        ulong start = ulong.Parse(Console.ReadLine());
        ulong end = ulong.Parse(Console.ReadLine());
        string symbols = Console.ReadLine();
        ulong reminder = 0;
        ulong sum = start;
        ulong secondSum = 0;
        for (ulong i = start; i < end; i++)
        {
            reminder = i % 5;

            if (reminder != 0)
            {
                sum += reminder;
            }
            else
            {
                secondSum += i;
            }
        }

        sum += (secondSum - start);

        //if (sum % 2 == 0)
        //{
        //    string result = sum.ToString();
        //    char symbol = result[0];
        //    var list = new List<string>();
        //    foreach (var item in result)
        //    {
        //        list.Add(item.ToString());
        //    }

        //    string temp = null;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i] == symbol.ToString())
        //        {
        //            list[i] = symbols;
        //            temp += list[i];
        //        }

        //        temp += list[i];
        //    }

        //    symbols = temp;
        //}
        else if (sum % 2 != 0)
        {
            string result = sum.ToString();
            string temp = null;
            char lastDigit = result[result.Length - 1];
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] == lastDigit)
                {
                    temp += symbols;
                }
                else
                {
                    temp += result[i];
                }
            }

            symbols = temp;
        }

        Console.WriteLine(symbols);
    }
}