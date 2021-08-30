using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tree.Problems
{

    // Definition for a binary tree node.  
    public class LCABinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root.val == p.val || root.val == q.val)
            {
                return root;
            }

            var leftSubtree = LowestCommonAncestor(root.left, p, q);
            var rightSubtree = LowestCommonAncestor(root.right, p, q);

            if (leftSubtree == null)
                return rightSubtree;
            if (rightSubtree == null)
                return leftSubtree;
            return root;

        }
    }
}
