using System;

class CheckForAPlayCard
{
    static void Main()
    {
        var cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        Console.Write("Enter character: ");
        string character = Console.ReadLine().ToUpper();
        string result = "No";

        for (int index = 0; index < cards.Length; index++)
        {
            if (character == cards[index])
            {
                result = "Yes";
                break;
            }
        }

        Console.WriteLine(result);
    }
}
