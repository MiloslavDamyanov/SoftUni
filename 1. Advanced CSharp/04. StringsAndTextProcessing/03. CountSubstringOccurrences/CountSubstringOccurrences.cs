using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSubstringOccurrences
{
    static void Main()
    {
        string input = Console.ReadLine();
        string str = Console.ReadLine().ToLower();
        int occurrences = 0;
        var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower()).ToList();
        int index = -1;
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].Contains(str))
            {
                index = words[i].IndexOf(str);
                while (index != -1)
                {
                    occurrences++;
                    index = words[i].IndexOf(str, index + 1);
                }

            }

        }

        Console.WriteLine(occurrences);
    }
}