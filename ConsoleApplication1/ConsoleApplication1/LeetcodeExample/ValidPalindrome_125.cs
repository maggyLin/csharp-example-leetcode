using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class ValidPalindrome_125
    {

        public bool IsPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s)) return true;

            int l = 0;
            int r = s.Length - 1;

            while (l < r)
            {
                // find left alphanumeric character
                if (!Char.IsLetterOrDigit(s[l]))
                {
                    l++;
                    continue;
                }
                // find right alphanumeric character
                if (!Char.IsLetterOrDigit(s[r]))
                {
                    r--;
                    continue;
                }
                // case insensitive compare
                if (Char.ToLower(s[l]) == Char.ToLower(s[r]))
                {
                    l++;
                    r--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }



    }
}
