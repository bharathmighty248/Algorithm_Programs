using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Anagram
    {
        public bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            else
            {
                bool check = true;
                char[] string1 = str1.ToLower().ToCharArray();
                char[] string2 = str2.ToLower().ToCharArray();
                Array.Sort(string1);
                Array.Sort(string2);
                for (int i = 0; i < str1.Length; i++)
                {
                    if (string1[i].CompareTo(string2[i]) != 0)
                    {
                        check = false;
                        break;
                    }
                }
                return check;
            }
        }
    }
}
