using System;

class PrintDeck52Cards
{
    static void Main()
    {
        string[] deck = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        string[] suitsCards = new string[] { "♣", "♦", "♥", "♠" };

        for (int j = 0; j < deck.Length; j++)
        {
            for (int i = 0; i < suitsCards.Length; i++)
            {

                if (suitsCards[i] == "♦" || suitsCards[i] == "♥")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (j != 9)
                    {
                        Console.Write("  {0}", deck[j]);
                    }
                    else
                    {
                        Console.Write(" {0}", deck[j]);
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0} ", suitsCards[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" {0}{1} ", deck[j], suitsCards[i]);
                }

            }

            Console.WriteLine();
        }
    }
}