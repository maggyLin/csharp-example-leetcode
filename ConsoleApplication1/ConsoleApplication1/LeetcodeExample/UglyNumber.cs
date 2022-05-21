using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    internal class UglyNumber
    {
        //An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.
        public bool IsUgly(int n)
        {
            if (n <= 0) return false;
            if (n == 1) return true;

            while (n > 1)
            {
                if (n % 2 == 0) n = n / 2;
                else if (n % 3 == 0) n = n / 3;
                else if (n % 5 == 0) n = n / 5;
                else return false;
            }

            return true;
        }


    }
}
