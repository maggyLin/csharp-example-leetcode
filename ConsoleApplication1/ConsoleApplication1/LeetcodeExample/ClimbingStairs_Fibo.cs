using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class ClimbingStairs_Fibo
    {

        //( F(n) = F(n-1) + F(n-2) )
        public static int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;

            int res = 0;      //F(n)
            int pre = 2;      // F(n-1)
            int prepre = 1;   //F(n-2)

            for (int i = 3; i <= n; i++)
            {
                res = pre + prepre;
                prepre = pre;
                pre = res;
            }

            return res;
        }


        //使用費氏數列的公式 ( F(n) = F(n-1) + F(n-2) , n>=3 )
        // https://ithelp.ithome.com.tw/articles/10218585
        public static int useFibo(int n)
        {
            double a1 = 1 / Math.Sqrt(5);
            double b2 = Math.Pow((1 + Math.Sqrt(5)) / 2, n + 1);
            double c3 = Math.Pow((1 - Math.Sqrt(5)) / 2, n + 1);
            int fx = (int)(a1 * (b2 - c3));
            return fx;
        }

    }
}
