using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings
{
    public class IsUnique
    {



        public bool CheckUnique(string toCheck)
        {
            bool repeat = false;  // switch this bool to int and it can be used to return index of repeat char
            HashSet<char> seen = new HashSet<char>();

            for (int i = 0; i < toCheck.Length && !repeat; ++i)
            {
                if(!(seen.Add(toCheck[i])))
                {
                    repeat = true;
                }
            }

            return repeat;
        }
    }
}
