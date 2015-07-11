using System;
using System.Collections.Generic;
using System.Linq;

class BabaTincheAirlines
{
    static void Main()
    {
        List<int> passangersFirstClass = new List<int>();
        List<int> passangersSecondClass = new List<int>();
        List<int> passangersThirdClass = new List<int>();
        int firstTiketPrice = 7000;
        int buissinesTiketPrice = 3500;
        int economyTiketPrice = 1000;

        string input = null;
        for (int i = 0; i < 3; i++)
        {
            input = Console.ReadLine();
            var splitted = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (i)
            {
                case 0:
                    passangersFirstClass.Add(int.Parse(splitted[0]));
                    passangersFirstClass.Add(int.Parse(splitted[1]));
                    passangersFirstClass.Add(int.Parse(splitted[2]));
                    break;
                case 1:
                    passangersSecondClass.Add(int.Parse(splitted[0]));
                    passangersSecondClass.Add(int.Parse(splitted[1]));
                    passangersSecondClass.Add(int.Parse(splitted[2]));
                    break;
                case 2:
                    passangersThirdClass.Add(int.Parse(splitted[0]));
                    passangersThirdClass.Add(int.Parse(splitted[1]));
                    passangersThirdClass.Add(int.Parse(splitted[2]));
                    break;
                default:
                    break;
            }
        }

        double totalMoney = (passangersFirstClass[0] * firstTiketPrice) + (passangersSecondClass[0] * buissinesTiketPrice) + (passangersThirdClass[0] * economyTiketPrice);

        double frequenFlyers = passangersFirstClass[1] * (0.3 * firstTiketPrice);
        frequenFlyers += passangersSecondClass[1] * (0.3 * buissinesTiketPrice);
        frequenFlyers += passangersThirdClass[1] * (0.3 * economyTiketPrice);

        double meal = passangersFirstClass[2] * (0.05 * firstTiketPrice);
        meal += passangersSecondClass[2] * (0.05 * buissinesTiketPrice);
        meal += passangersThirdClass[2] * (0.05 * economyTiketPrice);
        Console.WriteLine(totalMoney);
        Console.WriteLine(totalMoney - frequenFlyers - meal);
    }
}
