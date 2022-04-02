using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class PathSum
    {
        //https://leetcode.com/problems/path-sum/

        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false; //已經到底了
            if (root.left==null && root.right==null && root.val == targetSum) return true;
            //減去這次的targetSum,繼續向下檢查 (直到如上,到底而且值相等)
            return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

    }
}
