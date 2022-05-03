using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class HappyNumber_202
    {

        public static bool IsHappy(int n)
        {
            if (n == 1) return true;

            List<int> store = new List<int>(); //經歷過的數字
            string num = "";
            int tmpN = 0;

            while (n != 1)
            {
                num = n.ToString();

                n = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    tmpN = Convert.ToInt32(num[i]) - 48;  // ASC 0=48 1=49...
                    n = n + (tmpN * tmpN);
                }

                if (store.IndexOf(n) != -1) return false;  //進入迴圈(重複的數字)
                store.Add(n);
            }

            return true;  // n==1
        }


    }
}
