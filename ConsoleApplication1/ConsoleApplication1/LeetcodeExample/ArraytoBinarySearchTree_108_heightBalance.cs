using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class ArraytoBinarySearchTree_108_heightBalance
    {
        //將array轉成高度平衡的二元搜尋樹(左右節點深度相差均<=1)
        //深度相差均<=1 : 找到中位數當root -> 左/右邊再找中位數為此區塊root...

        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0) return null;
            return GetMidNode(nums, 0, nums.Length-1);
        }

        public TreeNode GetMidNode(int[] nums , int start , int end)
        {
            if (start > end) return null;
            int midIndex = start + (end - start) / 2;


            ////找到中位數當root
            //TreeNode rootNode = new TreeNode(nums[midIndex]);
            ////繼續向下 : 左/右邊再找中位數為此區塊root
            //rootNode.left = GetMidNode(nums, start, midIndex - 1);
            //rootNode.right = GetMidNode(nums, midIndex + 1 , end);

            TreeNode rootNode = new TreeNode(nums[midIndex], GetMidNode(nums, start, midIndex - 1), GetMidNode(nums, midIndex + 1, end));
            return rootNode;
        }


        /**
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         *         this.val = val;
         *         this.left = left;
         *         this.right = right;
         *     }
         * }
         */
    }
}
