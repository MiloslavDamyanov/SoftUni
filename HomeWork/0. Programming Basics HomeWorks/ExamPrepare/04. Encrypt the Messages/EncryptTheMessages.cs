using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class EncryptTheMessages
{
    static List<char> lowerAtoM = new List<char>();
    static List<char> lowerNtoZ = new List<char>();
    static List<char> capitalAtoM = new List<char>();
    static List<char> capitalNtoZ = new List<char>();
    static List<char> specialChars = new List<char> { ' ', ',', '.', '?', '!' };
    static List<char> newSpecialChars = new List<char> { '+', '%', '&', '#', '$' };
    static List<string> wordToEncrypt = new List<string>();
    static List<char> digits = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    static void Main()
    {
        SplitCharacters();
        Input();
        EncryptMessage();
        PrintResult();
    }

    private static void PrintResult()
    {
        if (wordToEncrypt.Count > 0)
        {
            Console.WriteLine("Total number of messages: {0}", wordToEncrypt.Count);
        }
        else
        {
            Console.WriteLine("No messages sent.");
        }

        for (int i = 0; i < wordToEncrypt.Count; i++)
        {
            Console.WriteLine(wordToEncrypt[i]);
        }
    }

    private static void EncryptMessage()
    {
        StringBuilder strBuilder = new StringBuilder();
        for (int i = 0; i < wordToEncrypt.Count; i++)
        {
            for (int index = wordToEncrypt[i].Length - 1; index >= 0; index--)
            {
                if (specialChars.Contains(wordToEncrypt[i][index]))
                {
                    strBuilder.Append(newSpecialChars[specialChars.IndexOf(wordToEncrypt[i][index])]);
                }

                if (lowerAtoM.Contains(wordToEncrypt[i][index]))
                {
                    strBuilder.Append(lowerNtoZ[lowerAtoM.IndexOf(wordToEncrypt[i][index])]);
                }
                else if (lowerNtoZ.Contains(wordToEncrypt[i][index]))
                {
                    strBuilder.Append(lowerAtoM[lowerNtoZ.IndexOf(wordToEncrypt[i][index])]);
                }

                if (capitalAtoM.Contains(wordToEncrypt[i][index]))
                {
                    strBuilder.Append(capitalNtoZ[capitalAtoM.IndexOf(wordToEncrypt[i][index])]);
                }
                else if (capitalNtoZ.Contains(wordToEncrypt[i][index]))
                {
                    strBuilder.Append(capitalAtoM[capitalNtoZ.IndexOf(wordToEncrypt[i][index])]);
                }

                if (digits.Contains(wordToEncrypt[i][index]))
                {
                    strBuilder.Append(wordToEncrypt[i][index]);
                }
            }

            wordToEncrypt[i] = strBuilder.ToString();
            strBuilder.Clear();
        }
    }

    private static void Input()
    {
        bool isEnable = true;
        while (isEnable)
        {
            string input = Console.ReadLine();
            if (input == "start" || input == "START")
            {
                while (input != "end" && input != "END")
                {
                    input = Console.ReadLine();
                    if (input != "end" && input != "END" && input != "")
                    {
                        wordToEncrypt.Add(input);
                    }
                    else
                    {
                        isEnable = false;
                    }
                }
            }

        }
    }

    private static void SplitCharacters()
    {
        char lowAtoM = 'a';
        char lowNtoZ = 'n';
        char capAtoM = 'A';
        char capNtoZ = 'N';
        for (int i = 0; i < 13; i++)
        {
            lowerAtoM.Add(lowAtoM);
            lowerNtoZ.Add(lowNtoZ);
            capitalAtoM.Add(capAtoM);
            capitalNtoZ.Add(capNtoZ);
            lowAtoM++;
            lowNtoZ++;
            capAtoM++;
            capNtoZ++;
        }
    }
}