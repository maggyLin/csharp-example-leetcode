using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class PowerofThree_326
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n == 1) return true;
            if (n < 3) return false;

            int q = n;

            while (q > 2)
            {
                if (q % 3 != 0) return false;
                else {
                    q = q / 3;
                    if (q == 0 || q == 2) return false;
                    if (q == 1) return true;
                }
                   
            }

            return true;
        }

        //一直除3 如果最後商數==1 => true
        public static bool IsPowerOfThree2(int n)
        {
            if (n < 1)
            {
                return false;
            }

            while (n % 3 == 0)
            {
                n /= 3;
            }

            return n == 1;
        }

    }
}
