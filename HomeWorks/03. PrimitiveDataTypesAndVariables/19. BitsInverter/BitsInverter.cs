using System;
using System.Collections.Generic;
using System.Text;

class BitsInverter
{
    static void Main()
    {
        int bytes = int.Parse(Console.ReadLine());
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

        // inverting bits
        List<int> indexToInvert = new List<int>();
        int count = 0;
        while (count <= bitsCount)
        {
            indexToInvert.Add(count);
            count += step;
        }

        StringBuilder sb = new StringBuilder();
        int index = 0;
        int bit = 0;
        for (int i = 0; i < mergeBits.Length; i++)
        {
            if (i == indexToInvert[index])
            {
                bit = int.Parse(mergeBits[i].ToString());
                sb.Append(bit ^= 1);

                if (index < indexToInvert.Count - 1)
                {
                    index++;
                }
            }
            else
            {
                sb.Append(mergeBits[i]);
            }
        }

        // add octets(8 bits = 1 octet) with inverted bits to array
        string[] invertedBits = new string[bytes];
        int countBits = 0;
        index = 0;
        for (int j = 0; j < sb.Length; j++)
        {
            invertedBits[index] += sb[j];
            countBits++;
            if (countBits == 8)
            {
                index++;
                countBits = 0;
            }
        }

        // print result to deciaml value
        for (int i = 0; i < invertedBits.Length; i++)
        {
            Console.WriteLine(Convert.ToInt32(invertedBits[i].ToString(), 2));
        }
    }
}