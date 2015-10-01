using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SequencesOfEqualStrings
{
    static void Main()
    {
        string input = Console.ReadLine();
        var arr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        
        if (arr.Count == 1)
        {
            Console.WriteLine(arr[0]);
        }
        else if (arr.Count > 1)
        {
            int nextIndex = 1;
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
                if (arr[i] != arr[nextIndex])
                {
                    Console.WriteLine();
                }

                if (nextIndex < arr.Count - 1)
                {
                    nextIndex++;
                }
            }

            Console.WriteLine();
        }        
    }
}