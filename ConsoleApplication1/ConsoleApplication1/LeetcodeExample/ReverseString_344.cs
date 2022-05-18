using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    //https://leetcode.com/problems/reverse-string/
    internal class ReverseString_344
    {
        public void ReverseString(char[] s)
        {
            //前後交換, 指標往內計算
            int len = s.Length;
            char tmp;
            for (int i = 0; i < (len/2); i++)
            {
                tmp = s[len-(1+i)];
                s[len - (1 + i)] = s[i];
                s[i] = tmp;
            }
        }
    }
}
