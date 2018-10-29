using System;
using System.Collections.Generic;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "abcdefghijklmnop";

            IsUnique chars = new IsUnique();

            Console.WriteLine(chars.CheckUnique(test));

        }
    }
}
