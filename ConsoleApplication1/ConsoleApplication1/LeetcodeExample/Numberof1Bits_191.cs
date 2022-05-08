using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class Numberof1Bits_191
    {
        // 轉10進位->被2除多少次->有多少個1
        public static int HammingWeight(uint n)
        {
            int count = 0;
            while (n>0)
            {
                if (n % 2 !=0) count++;
                n /= 2;
                //Console.WriteLine(n);
            }
            return count;
        }
    }
}
