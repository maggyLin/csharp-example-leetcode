using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class LargestRectangleInHistogram
    {

        /* 
         * 參考https://medium.com/hoskiss-stand/largest-rectangle-b3a7473320c1
         * 建議範例 int[] nums1 = { 2,1,2 };
         */
        public static int Final2(int[] heights)
        {
            Stack<int> s = new Stack<int>();

            //最後補上0高度,避免length=1,或是有minH=1沒check到
            Array.Resize(ref heights, (heights.Length + 1));
            heights[heights.Length - 1] = 0;

            int maxArea = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                while (s.Count() > 0 && heights[s.Peek()] >= heights[i])
                {
                    int indexH = s.Pop();
                    int tmp = s.Count() > 0 ? s.Peek() : -1;
                    int W = (i - tmp - 1); // if s.Peek() 沒有值, 表示高都比這個長,所以寬 = i
                    maxArea = Math.Max(maxArea, (heights[indexH] * W));
                }
                s.Push(i);
            }

            return maxArea;
        }

        /* O(n^2)
         * 根據目前index,往前跟往後檢查,直到比目前小,計算總width
         */
        public int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                int indexH = heights[i];

                //此值可能獲得的最大面積 > 目前最大面積
                if (indexH > 0 && (indexH * heights.Length) > maxArea)
                {

                    int indexW = 1;

                    // 往後確認
                    for (int j = (i + 1); j < heights.Length; j++)
                    {
                        if (heights[j] >= indexH) indexW++;
                        else break;
                    }

                    // 往前確認             
                    for (int k = (i - 1); k >= 0; k--)
                    {
                        if (heights[k] >= indexH) indexW++;
                        else break;
                    }


                    int indexArea = indexW * indexH;
                    //此index的面積 > 目前最大面積
                    if (indexArea > maxArea) maxArea = indexArea;
                }
            }

            return maxArea;
        }


    }
}
