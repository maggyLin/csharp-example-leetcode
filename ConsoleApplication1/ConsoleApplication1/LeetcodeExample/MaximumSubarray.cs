using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class MaximumSubarray
    {
        //int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        //Console.WriteLine(MaximumSubarray.MaxSubArray(nums));


        public static int MaxSubArray(int[] nums)
        {
            int curMax = nums[0];  //目前最大值
            int nowMax = nums[0];  //包含目前項目計算出的最大值

            for(int i = 1; i < nums.Length; i++)
            {
                //計算包含之前項目最大值是否比[i]自己大
                nowMax = Math.Max(nums[i], (nums[i] + nowMax));
              
                curMax = Math.Max(nowMax, curMax);
            }

            return curMax;
        }
    }
}
