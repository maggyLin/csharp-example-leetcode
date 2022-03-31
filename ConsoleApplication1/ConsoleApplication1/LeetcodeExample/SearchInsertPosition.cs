using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class SearchInsertPosition
    {

        public static int searchInsert(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int i = 0;  //上界
            int j = nums.Length - 1; //下界

            int index = -1;

            while (i <= j)
            {
                index = (i + j) / 2;
                if (nums[index] == target)
                    return index;
                if (nums[index] >= target)
                    j = index - 1;
                else
                    i = index + 1;
            }
            return i;
        }



    }
}
