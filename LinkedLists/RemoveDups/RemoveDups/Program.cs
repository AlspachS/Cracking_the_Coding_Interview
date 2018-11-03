using System;
using System.Collections.Generic;

namespace RemoveDups
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);

            RemoveDupNodes testOperations = new RemoveDupNodes();
            foreach (string word in sentence)
            {
                Console.WriteLine(word);
            }
            sentence = testOperations.PerformRemovalWBuffer(sentence);
            foreach (string word in sentence)
            {
                Console.WriteLine(word);
            }
        }
    }
}
