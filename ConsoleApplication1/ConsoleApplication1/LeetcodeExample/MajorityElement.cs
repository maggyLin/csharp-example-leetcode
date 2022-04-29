using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class MajorityElement
    {

        public int MajorityElementEx(int[] nums)
        {
            // more than [n / 2] times : 中間一定會是最多次的數字
            Array.Sort(nums);
            int mid = nums.Length / 2;
            return nums[mid];
        }

    }
}
