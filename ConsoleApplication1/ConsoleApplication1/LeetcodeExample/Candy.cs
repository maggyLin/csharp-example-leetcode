using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class Candy
    {

        public static int Solution(int[] ratings)
        {
            int total = 0;
            int rightCount = 1;
            int leftCount = 1;
            int count = 1;  //上次的數值
            int checkIndex = 0;

            for (int i = 0; i < ratings.Length ; i++)
            {
                checkIndex = i;
                rightCount = 1;
                leftCount = 1;

                //跟左邊比 , if > (上個數值+1) , 第一個不用往左
                if (i > 0 && (ratings[i] > ratings[i - 1])) leftCount = count + 1;

                //跟右邊比, 要一直往下比較,確認增加幾個數值( 3,2,1 => 要為3) , 最後一個不用往右
                while (checkIndex < (ratings.Length - 1) && (ratings[checkIndex] > ratings[checkIndex+1]) )
                {
                    rightCount++;
                    checkIndex++;
                }
                //左右互相比較,取較大的
                count = rightCount > leftCount ? rightCount : leftCount;
                total += count;
            }

            return total;
        }



    }

    class CandySolution
    {
        public static int count(int n)
        {
            return (n * (n + 1)) / 2;
        }
        public static int candy(int[] ratings)
        {
            if (ratings.Length <= 1)
            {
                return ratings.Length;
            }
            int candies = 0;
            int up = 0;
            int down = 0;
            int oldSlope = 0;
            for (int i = 1; i < ratings.Length; i++)
            {
                int newSlope = (ratings[i] > ratings[i - 1]) ? 1
                    : (ratings[i] < ratings[i - 1] ? -1
                    : 0);

                if ((oldSlope > 0 && newSlope == 0) || (oldSlope < 0 && newSlope >= 0))
                {
                    candies += count(up) + count(down) + Math.Max(up, down);
                    up = 0;
                    down = 0;
                }
                if (newSlope > 0)
                {
                    up++;
                }
                else if (newSlope < 0)
                {
                    down++;
                }
                else
                {
                    candies++;
                }

                oldSlope = newSlope;
            }
            candies += count(up) + count(down) + Math.Max(up, down) + 1;
            return candies;
        }
    }
}
