using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class MissingNumber
    {
        public int MissingNumberEx(int[] nums)
        {
            int len = nums.Length;

            for (int i = 0; i < len; i++)
            {
                if (Array.IndexOf(nums, i) == -1) return i;
            }

            return len;
        }
    }
}
