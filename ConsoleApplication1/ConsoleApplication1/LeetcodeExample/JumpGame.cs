using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class JumpGame
    {
        //不斷更新最遠能抵達的距離，如果目前的位置超出這個距離，
        //代表我們已經到了到不了的地方，可以直接 return false；
        public static bool CanJump(int[] nums)
        {
            int len = nums.Length;
            if ( len == 0) return false;

            int maxIndex = 0;  //目前可以到達最大index位置

            for(int i = 0; i < nums.Length; i++)
            {
                // 到i位置之前的數值,最大值都無法到達i位置
                if (i > maxIndex) return false;

                //已經可以到達最終位置了
                if (maxIndex >= len) return true; 

                maxIndex = Math.Max(maxIndex, (i + nums[i]));
            }

            return true;
        }

    }
}
