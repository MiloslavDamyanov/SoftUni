using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class WiggleWiggle
{
    static void Main()
    {
        string input = Console.ReadLine(); // "36854775807 2285477580";  // "4558 488755 25 555"
        var numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        ConvertToBinary(numbers);
        var reversedNums = ReverseBits(numbers);
        reversedNums = SwapEvenBits(reversedNums);


        for (int index = 0; index < reversedNums.Count; index++)
        {
            StringBuilder sb = new StringBuilder(reversedNums[index]);
            for (int i = 0; i < 64; i++)
            {
                if (sb[i] == '0')
                {
                    sb[i] = '1';
                }
                else if (sb[i] == '1')
                {
                    sb[i] = '0';
                }
            }

            reversedNums[index] = sb.ToString();
        }

        RemoveSignBit(reversedNums);

        for (int i = 0; i < reversedNums.Count; i++)
        {
            Console.WriteLine("{0} {1}", Convert.ToUInt64(reversedNums[i], 2), reversedNums[i]);
        }

    }

    private static void RemoveSignBit(List<string> reversedNums)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < reversedNums.Count; i++)
        {
            for (int j = 1; j < reversedNums[i].Length; j++)
            {
                sb.Append(reversedNums[i][j]);
            }

            reversedNums[i] = sb.ToString();
            sb.Clear();
        }
    }


    private static List<string> SwapEvenBits(List<string> reversedNums)
    {
        int nextIndex = 1;
        char tempBit = ' ';
        for (int index = 0; index < reversedNums.Count - 1; index++)
        {
            StringBuilder sb1 = new StringBuilder(reversedNums[index]);
            StringBuilder sb2 = new StringBuilder(reversedNums[nextIndex]);

            for (int i = 0; i < 64; i++)
            {
                if (i % 2 == 0)
                {
                    if (sb1[i] != sb2[i])
                    {
                        tempBit = sb1[i];
                        sb1[i] = sb2[i];
                        sb2[i] = tempBit;
                        tempBit = ' ';

                        reversedNums[index] = sb1.ToString();
                        reversedNums[nextIndex] = sb2.ToString();
                    }
                }
            }

            index++;
            nextIndex = index + 1;
            nextIndex++;
        }

        reversedNums = ReverseBits(reversedNums);
        return reversedNums;
    }

    private static void ConvertToBinary(List<string> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] = Convert.ToString(long.Parse(numbers[i]), 2).PadLeft(64, '0');
        }
    }

    private static List<string> ReverseBits(List<string> numbers)
    {
        List<string> reversedNums = new List<string>();
        string temp = null;
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = numbers[i].Length - 1; j >= 0; j--)
            {
                temp += numbers[i][j];
            }

            reversedNums.Add(temp);
            temp = null;
        }

        return reversedNums;
    }
}