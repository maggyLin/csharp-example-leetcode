using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    internal class ContainsDuplicate_217
    {
        //https://leetcode.com/problems/contains-duplicate/
        public bool ContainsDuplicate(int[] nums)
        {
            int[] n = nums.Distinct().ToArray();

            if (n.Length != nums.Length) return true;
            else return false;
        }

    }
}
