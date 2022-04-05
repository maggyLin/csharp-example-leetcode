using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class MaximumDepthof_BinaryTree
    {
        // 二元樹的MAX深度
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            return Math.Max(MaxDepth(root.right), MaxDepth(root.left)) + 1;

        }

        public int MaxDepth2(TreeNode root)
        {
            // 節點到底
            if (root == null) return 0;
            
            int deepL = 1;
            int deepR = 1;
            // 有左節點，往下一層找
            if (root.left != null)
            {
                deepL += MaxDepth2(root.left);
            }
            // 有右節點，往下一層找
            if (root.right != null)
            {
                deepR += MaxDepth2(root.right);
            }

            // 回傳較大的深度depth，給上一層節點
            return deepL > deepR ? deepL : deepR;
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
