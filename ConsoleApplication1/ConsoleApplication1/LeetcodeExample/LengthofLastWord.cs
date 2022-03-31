using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class LengthofLastWord
    {

        public static int LengthOfLastWord(string s)
        {

            //string[] sAry = s.Split(' ');

            //可能會有多個空格  EX: s = "   fly me   to   the moon  "


            string[] sAry = s.Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            return sAry[sAry.Length - 1].Length;


        }


    }
}
