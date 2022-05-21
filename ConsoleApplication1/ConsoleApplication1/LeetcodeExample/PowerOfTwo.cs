using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    internal class PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;  //有負數
            if (n < 3) return true;

            while (n > 1)
            {
                if (n % 2 != 0) return false;
                n = n / 2;
            }

            return true;
        }
    }
}
