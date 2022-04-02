using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class RemoveDuplicatesfromSortedArray
    {
        //int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        //Console.WriteLine(RemoveDuplicatesfromSortedArray.RemoveDuplicates(nums));

        public static int RemoveDuplicates(int[] nums)
        {
            //index 0 一定不會重複
            int index = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[(index-1)])
                {
                    nums[index] = nums[i];
                    index++;
                }

            }
            return index;
        }

    }
}
