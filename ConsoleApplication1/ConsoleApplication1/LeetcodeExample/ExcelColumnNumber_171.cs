using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    //A...Z  26 進制的數值遞增
    //AA = 1* (26^1) + 1* (26^0) = 27
    //ZY = 26* (26^1) + 25* (26^0) = 701

    //將字串分別取出字元A-Z，根據ANSI CODE，A的code為65，A = 65 - 64 = 1

    class ExcelColumnNumber_171
    {
        public int TitleToNumber(string columnTitle)
        {
            int sum = 0;
            int charNum = 0;

            for(int i = 0; i < columnTitle.Length; i++)
            {
                charNum = Convert.ToInt32(columnTitle[i]) - 64;
                sum = sum + Convert.ToInt32(charNum * (Math.Pow(26, columnTitle.Length - 1 - i)));
            }
            return sum;
        }


    }

}
