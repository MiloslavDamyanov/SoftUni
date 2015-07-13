using System;
using System.Collections.Generic;
using System.Text;

class BitKiller
{
    static void Main()
    {
        byte bytes = byte.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] addNums = new int[bytes];
        int bitsCount = 8 * bytes;

        for (int i = 0; i < addNums.Length; i++)
        {
            addNums[i] = int.Parse(Console.ReadLine());
        }

        // convert to binary and merge bits      
        string mergeBits = null;
        for (int i = 0; i < addNums.Length; i++)
        {
            mergeBits += Convert.ToString(addNums[i], 2).PadLeft(8, '0');
        }

        // get index of bits to invert
        List<int> listIndex = new List<int>();
        int count = 1;
        while (count <= bitsCount)
        {
            listIndex.Add(count);
            count += step;
        }

        StringBuilder sb = new StringBuilder(mergeBits);

        for (int j = 0; j < listIndex.Count; j++)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                if (listIndex[j] == i)
                {
                    sb[i] = '^';
                }
            }
        }

        string tempStr = null;
        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] != '^')
            {
                tempStr += sb[i];
            }
        }

        string result = tempStr.PadRight(tempStr.Length + listIndex.Count, '0');

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

        // convert bits to deciaml and print them
        for (int i = 0; i < listOfBits.Count; i++)
        {
            if (Convert.ToInt32(listOfBits[i], 2) != 0)
            {
                Console.WriteLine(Convert.ToInt32(listOfBits[i], 2));
            }
        }
    }
}