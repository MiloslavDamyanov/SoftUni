using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Palindromes
{
    static void Main()
    {
        string input = Console.ReadLine();
        var words = input.Split(new char[] { ' ', ',', '?', '!', '.', '-', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList(); 
        var palindromes = new List<string>();

        for (int i = 0; i < words.Count; i++)
        {
            var word = words[i].ToList();
            word.Reverse();
            string reversed = string.Join("", word);
            
            if (words[i] == reversed)
            {
                palindromes.Add(words[i]);
            }
        }

        palindromes.Sort();
        Console.WriteLine(string.Join(", ", palindromes));
    }
}
