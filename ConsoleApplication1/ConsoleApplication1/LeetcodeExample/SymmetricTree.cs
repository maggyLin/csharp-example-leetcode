using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            // 不管第一個節點 , 切成2塊做比對 ,最左邊==最右邊
            // 可以參考 SameTree.cs(比對是否相同)

            if (root == null) return true;
            return check(root.left, root.right);
        }
        public bool check(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            if (left.val != right.val) return false;
            return check(left.left, right.right) && check(left.right, right.left);
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
