using System;
using System.Collections.Generic;

class BitShifting
{
    static void Main()
    {
        Int64 sieve = Int64.Parse(Console.ReadLine());
        int countOfSieves = int.Parse(Console.ReadLine());
        Int64[] array = new Int64[countOfSieves];
        string[] binary = new string[countOfSieves];
        int countOnes = 0;
        int countZeros = 0;

        string sieveBits = Convert.ToString(sieve, 2);
        if (countOfSieves == 0)
        {
            for (int i = 0; i < sieveBits.Length; i++)
            {
                if (sieveBits[i] == '1')
                {
                    countOnes++;
                }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Int64.Parse(Console.ReadLine());
            }

            for (int i = 0; i < binary.Length; i++)
            {
                binary[i] = Convert.ToString(array[i], 2);
            }

            int totalWidth = binary[0].Length;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i].Length > totalWidth)
                {
                    totalWidth = binary[i].Length;
                }
            }

            if (totalWidth < sieveBits.Length)
            {
                totalWidth = sieveBits.Length;
            }

            List<string> binaryList = new List<string>();
            binaryList.Add(sieveBits.PadLeft(totalWidth, '0'));

            for (int i = 0; i < countOfSieves; i++)
            {
                binaryList.Add(binary[i].PadLeft(totalWidth, '0'));
            }

            for (int col = 0; col < totalWidth; col++)
            {
                countZeros = 0;
                if (binaryList[0][col] == '1')
                {
                    for (int row = 1; row < binaryList.Count; row++)
                    {
                        if (binaryList[row][col] == '0')
                        {
                            countZeros++;
                            if (countZeros == binaryList.Count - 1)
                            {
                                countOnes++;
                                countZeros = 0;
                            }
                        }
                        else if (binaryList[row][col] == '1')
                        {
                            countZeros = 0;
                        }
                    }
                }
            }
        }

        Console.WriteLine(countOnes);
    }
}