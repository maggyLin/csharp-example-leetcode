using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class DiameterOfBinaryTree
    {
        //https://ithelp.ithome.com.tw/articles/10227129
        //MaximumDepthof BinaryTree.cs
        //This path may or may not pass through the root.-----------------

        int max = 0;
        public int DiameterOfBinaryTreeEx2(TreeNode root)
        {
            MaxDepth2(root);
            return max;
        }
        public int MaxDepth2(TreeNode root)
        {
            if (root == null) return 0;

            int left = MaxDepth2(root.left);
            int right = MaxDepth2(root.right);

            //取所有left+rigth最大值
            max = Math.Max(max, left + right);

            return Math.Max(left, right) + 1;
        }



        //以下方法為一定會通過 root 中心節點!!!!!-----------------------------------
        public int DiameterOfBinaryTreeEx(TreeNode root)
        {
            // 左邊最長 + 右邊最長
            return MaxDepth(root.left) + MaxDepth(root.right);
        }


        // 二元樹的MAX深度
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(MaxDepth(root.right), MaxDepth(root.left)) + 1;
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
