using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class BestTimetoBuyandSellStock
    {
        //最大獲利 = 目前價錢 - 前面出現的最低價格
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0; //目前差額最大值
            int min = 100000;  //目前可買進最小值 (0 <= prices[i] <= 10^4)

            for (int i = 0; i < prices.Length; i++)
            {
                min = Math.Min(min, prices[i]);
                maxProfit = Math.Max(maxProfit, (prices[i] - min));
            }
            return maxProfit;
        }


        //算出每個跟後面的差額,記下差額最大的
        // Time Limit Exceeded...
        public static int MaxProfit00(int[] prices)
        {
            int maxProfit = 0;
            int diff = 0;

            for (int i=0; i < (prices.Length-1); i++)
            {
                for(int j=(i+1);j< prices.Length; j++)
                {
                    diff = prices[j] - prices[i];
                    maxProfit = diff > maxProfit ? diff : maxProfit ;
                }
            }
            return maxProfit;
        }
    }
}
