using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class BinaryTreeInorderTraversal
    {

        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            helper(root, res);
            return res;
        }

        public void helper(TreeNode root, List<int> res)
        {
            if (root != null)
            {
                helper(root.left, res);
                res.Add(root.val);
                helper(root.right, res);
            }
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
