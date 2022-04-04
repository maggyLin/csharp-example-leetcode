using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{

    //int[] nums1 = { 1, 2, 3, 0, 0, 0 }, nums2 = { 2, 5, 6 };
    //int m = 3, n = 3;
    //MergeSortedArray.Merge(nums1, m, nums2, n);

    class MergeSortedArray
    {

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums2, 0, nums1, m, n);
            Array.Sort(nums1);
        }

        public static void Merge3(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums2, 0, nums1, m, n);

            int temp = 0;

            for (var i = 0; i < nums1.Length; i++)
            {
                int j = i;
                while(j>0 && (nums1[j] < nums1[j-1]))
                {
                    temp = nums1[j];
                    nums1[j] = nums1[j-1];
                    nums1[j-1] = temp;
                    j--;
                }
            }

            //foreach (int item in nums1)
            //{
            //    Console.WriteLine(item);
            //}
        }


        public void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            int[] res = new int[m + n];
            int temp = 0;
            for (var i = 0; i < nums2.Length; i++)
            {
                nums1[m] = nums2[i];
                m++;
            }

            for (var i = 0; i < nums1.Length; i++)
            {
                for (var j = i + 1; j < nums1.Length; j++)
                {
                    if (nums1[i] > nums1[j])
                    {
                        temp = nums1[i];
                        nums1[i] = nums1[j];
                        nums1[j] = temp;
                    }

                }
            }
        }

    }
}
