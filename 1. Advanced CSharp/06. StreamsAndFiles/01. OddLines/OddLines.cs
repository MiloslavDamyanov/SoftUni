using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

class OddLines
{
    static void Main()
    {
        // ReadFilePrintAllText();
        ReadFileAndPrintOddLines();

    }

    static void ReadFilePrintAllText()
    {
        StreamReader reader = new StreamReader("../../text.txt", Encoding.GetEncoding("Windows-1251"));
        using (reader)
        {
            string fileContains = reader.ReadToEnd();
            Console.WriteLine("\nAll text: ");
            Console.WriteLine(fileContains);
            Console.WriteLine("\nOdd Lines: ");
        }
    }

    static void ReadFileAndPrintOddLines()
    {
        StreamReader reader = new StreamReader("../../text.txt", Encoding.GetEncoding("Windows-1251"));
        using (reader)
        {
            int oddLine = 0;
            string fileContains = string.Empty;
            while (fileContains != null)
            {
                oddLine++;
                fileContains = reader.ReadLine();
                if (oddLine % 2 != 0)
                {
                    Console.WriteLine(fileContains);
                }
            }
        }
    }
}
