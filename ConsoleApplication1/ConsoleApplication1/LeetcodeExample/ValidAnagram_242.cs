using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    //https://leetcode.com/problems/valid-anagram/
    internal class ValidAnagram_242
    {

        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length) return false;

            char[] chars = s.ToCharArray();
            char[] chars2 = t.ToCharArray();

            Array.Sort(chars);
            Array.Sort(chars2);
            return chars2.SequenceEqual(chars);
        }
    }
}
