using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    //https://leetcode.com/problems/intersection-of-two-arrays-ii/
    internal class IntersectionOfTwoArraysII_350
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> list1 = nums1.ToList();
            List<int> list2 = nums2.ToList();
            List<int> res = new List<int>();

            for (int i = 0; i < list1.Count; i++)
            {
                int index = list2.IndexOf(list1[i]);
                if (index != -1)
                {
                    res.Add(list1[i]);
                    list2.RemoveAt(index);
                }
            }

            return res.ToArray();

        }
    }
}
