using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    //https://leetcode.com/problems/move-zeroes/
    class MoveZeroes
    {
        //Note that you must do this in-place without making a copy of the array.

        //先把非0的都放入原本array,剩下都補0
        public void MoveZeroesEx1(int[] nums)
        {
            int i = 0; int j = 0;
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            for (int k = j; k < nums.Length; k++)
            {
                nums[k] = 0;
            }

        }

        //參考 : https://ithelp.ithome.com.tw/articles/10221042
        //先用pointer 紀錄第一個0位置
        //nums[i]非0 且 i != pointer時,交換位置
        public void MoveZeroesEx2(int[] nums)
        {
            int pointer = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (pointer != i)
                    {
                        nums[pointer] = nums[i];
                        nums[i] = 0;
                    }
                    pointer++;
                }
            }

        }

    }
}
