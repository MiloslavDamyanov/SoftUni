using System;
using System.Collections.Generic;
using System.Text;

class CatchTheBits
{
    static void Main()
    {
        byte bytes = byte.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] inputNumbers = new int[bytes];
        int bitsCount = 8 * bytes;

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            inputNumbers[i] = int.Parse(Console.ReadLine());
        }

        // convert to binary        
        string mergeBits = null;
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            mergeBits += Convert.ToString(inputNumbers[i], 2).PadLeft(8, '0');
        }

        List<int> listIndex = new List<int>();
        int count = 1;
        while (count <= bitsCount)
        {
            listIndex.Add(count);
            count += step;
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < listIndex.Count; i++)
        {
            sb.Append(mergeBits[listIndex[i]]);
        }

        int PadLength = sb.Length <= 8 ? 8 : sb.Capacity;
        string result = string.Format(sb.ToString().PadRight(PadLength, '0'));

        List<string> listOfBits = new List<string>();
        string temp = null;
        int countBits = 0;
        int index = 0;
        for (int j = 0; j < result.Length; j++)
        {
            temp += result[j];
            countBits++;
            if (countBits == 8)
            {
                index++;
                countBits = 0;
                listOfBits.Add(temp);
                temp = null;
            }
        }

        for (int i = 0; i < listOfBits.Count; i++)
        {
            if (Convert.ToInt32(listOfBits[i], 2) != 0)
            {
                Console.WriteLine(Convert.ToInt32(listOfBits[i], 2));
            }
        }
    }
}
