namespace _05.NumeralSystemConversions
{
    using System;
    using System.Collections.Generic;

    class NumSysConverter
    {
        static void Main()
        {
            DecToBin(1234);
            DecToHex(1234);
            BinToDec("01100101");
            BinToHex("01100101"); // bits count must be 4, 8, 16, 32, 64 ... if not add zeros
            HexToDec("ABC");
            HexToBin("ABC");
        }

        private static void DecToBin(int number)
        {
            int result = 0;
            int bit = 0;
            List<int> binary = new List<int>();
            while (number != 0)
            {
                bit = number % 2;
                result = number / 2;
                number = result;
                binary.Add(bit);
            }

            binary.Reverse();
            string str = null;

            foreach (var bin in binary)
            {
                str += bin.ToString();
            }

            Console.WriteLine(str);
        }

        private static void DecToHex(int number)
        {
            char[] hex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int result = 0;
            int reminder = 0;
            List<int> value = new List<int>();
            while (number != 0)
            {
                reminder = number % 16;
                result = number / 16;
                number = result;
                value.Add(reminder);
            }

            value.Reverse();
            string str = null;

            for (int i = 0; i < value.Count; i++)
            {
                str += hex[value[i]];
            }

            Console.WriteLine(str);
        }

        private static void BinToDec(string strNumber)
        {
            // get last digit and add to array
            int len = strNumber.Length;
            int number = int.Parse(strNumber);
            int sum = 0;
            int[] arr = new int[len];

            for (int i = 0; i < len; i++)
            {
                int digit = number % 10;
                number /= 10;
                arr[i] = digit;
            }

            for (int i = 0, pow = 0; i < arr.Length; pow++, i++)
            {
                sum += arr[i] * (int)Math.Pow(2, pow);
            }

            Console.WriteLine(sum);
        }

        private static void BinToHex(string binNumber)
        {
            string[] arrBin = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111", };
            char[] arrHex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            string hexNumber = null;
            int bitsCount = 4;
            string currentOctet = null;
            int currentBit = 0;
            int end = bitsCount;

            for (int i = 0; i < binNumber.Length / bitsCount; i++)
            {
                for (currentBit = currentBit; currentBit < end; currentBit++)
                {
                    currentOctet += binNumber[currentBit];
                }

                for (int index = 0; index < arrBin.Length; index++)
                {
                    if (currentOctet == arrBin[index])
                    {
                        hexNumber += arrHex[index];
                        currentOctet = null;
                    }
                }

                end += bitsCount;
            }

            Console.WriteLine(hexNumber);
        }

        private static void HexToDec(string hexNumber)
        {
            int[] arr = new int[hexNumber.Length];
            char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            for (int i = 0; i < hexNumber.Length; i++)
            {
                for (int index = 0; index < symbols.Length; index++)
                {
                    if (hexNumber[i] == symbols[index])
                    {
                        arr[i] = index;
                    }
                }
            }

            int pow = 0;
            int sum = 0;
            int result = 0;
            for (int i = hexNumber.Length - 1; i >= 0; i--)
            {
                result = arr[i] * (int)Math.Pow(16, pow);
                pow++;
                sum += result;
            }

            Console.WriteLine(sum);
        }

        private static void HexToBin(string value)
        {
            string[] arrBin = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111", };
            char[] arrHex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            string binaryNumber = null;
            for (int pos = 0; pos < value.Length; pos++)
            {
                for (int index = 0; index < arrBin.Length; index++)
                {
                    if (value[pos] == arrHex[index])
                    {
                        binaryNumber += arrBin[index];
                    }
                }
            }

            Console.WriteLine(binaryNumber);
        }
    }
}

//  Convert 1234d to binary and hexadecimal numeral systems.
//  Convert 1100101b to decimal and hexadecimal numeral systems.
//  Convert ABChex to decimal and binary numeral systems.
