﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.LeetcodeExample
{
    class SameTree
    {

        // 可同步參考 SymmetricTree (鏡像比對)
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            // p and q are both null
            if (p == null && q == null) return true;
            // one of p and q is null
            if (q == null || p == null) return false;
            if (p.val != q.val) return false;
            return IsSameTree(p.right, q.right) &&
                    IsSameTree(p.left, q.left);
        }

    }
}
