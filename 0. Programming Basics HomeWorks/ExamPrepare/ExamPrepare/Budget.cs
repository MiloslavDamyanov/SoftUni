using System;

class Budget
{
    static void Main()
    {
        int totalDays = 30;
        int rent = 150;

        int amountOfMoney = int.Parse(Console.ReadLine());
        int weekdaysOut = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());

        int totalBudget = weekdaysOut * ((int)(((double)3 / 100) * amountOfMoney) + 10);
        int expense = (2 * 4) * 10;
        int normalWeekends = (totalDays - (hometown * 4)) - weekdaysOut;
        normalWeekends *= 10; // 10 lv expense
        int total = totalBudget + expense + normalWeekends + rent;
        int moneyLeft = amountOfMoney - total;

        if (moneyLeft > 0)
        {
            Console.WriteLine("Yes, leftover {0}.", moneyLeft);
        }
        else if (moneyLeft < 0)
        {
            Console.WriteLine("No, not enough {0}.", moneyLeft * (-1));
        }
        else
        {
            Console.WriteLine("Exact Budget.");
        }
    }
}