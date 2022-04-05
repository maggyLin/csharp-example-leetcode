using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class SingleNumber
    {

        public int FindSingleNumber(int[] nums)
        {
            int tmp = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                //將i值佔存起來,修改i值,使用indexof確認重複,回復i值
                tmp = nums[i];
                //避免修改後超出範圍
                nums[i] =  nums[i] > 0 ? nums[i]-1 : nums[i] + 1;
                int res = Array.IndexOf(nums, tmp);
                if (res == -1) break;
                else nums[i] = tmp;
            }

            return tmp;
        }

    }
}
