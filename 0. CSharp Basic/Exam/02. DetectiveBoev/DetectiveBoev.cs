using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DetectiveBoev
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string encryptedMessage = Console.ReadLine();
        var swList = new List<int>();
        int mask = 0;

        WordToAsciiNum(secretWord, swList);
        mask = SumElements(mask, swList);
        string output = DecryptMessage(encryptedMessage, mask);

        Console.WriteLine(output);
    }

    private static string DecryptMessage(string encryptedMessage, int mask)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            if ((int)encryptedMessage[i] % mask == 0)
            {
                result.Append((char)((int)encryptedMessage[i] + mask));
            }
            else
            {
                result.Append((char)((int)encryptedMessage[i] - mask));
            }
        }

        string output = null;
        for (int i = result.ToString().Length - 1; i >= 0; i--)
        {
            output += result[i];
        }
        return output;
    }

    private static void WordToAsciiNum(string secretWord, List<int> swList)
    {
        for (int i = 0; i < secretWord.Length; i++)
        {
            swList.Add((int)secretWord[i]);
        }
    }

    private static int SumElements(int mask, List<int> swList)
    {
        string sum = swList.Sum().ToString();
        var listSums = new List<int>();

        int tempSum = 0;
        while (sum.Length != 1)
        {
            for (int i = 0; i < sum.Length; i++)
            {
                tempSum += int.Parse(sum[i].ToString());
            }

            if (tempSum.ToString().Length == 1)
            {
                sum = tempSum.ToString();
                break;
            }


            listSums.Add(tempSum);
            sum = tempSum.ToString();
            tempSum = 0;
        }

        mask = int.Parse(sum.ToString());
        return mask;
    }
}