using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).

//For example:
//Given binary tree[3, 9, 20, null, null, 15, 7],
//    3
//   / \
//  9  20
//    /  \
//   15   7
//return its level order traversal as:
//[
//  [3],
//  [9,20],
//  [15,7]
//]

namespace AlgorithmPractice.Tree.Problems
{
    public class PrintLevelOrderSolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            Queue<TreeNode> visited = new Queue<TreeNode>();
            IList<IList<int>> LevelTraversedNodes = new List<IList<int>>();
            visited.Enqueue(root);
            TreeNode nextNode;
            List<int> currentLevelNodes;
            bool leftToRight = true;
            if (root?.left == null && root?.right == null)
            {
                if (root != null)
                {
                     LevelTraversedNodes.Add(new List<int> { root.val });
                }
                return LevelTraversedNodes;
            }
            while (true)
            {
                int nodeCount = visited.Count;
                if (nodeCount == 0)
                    break;
                currentLevelNodes = new List<int>();
                while (nodeCount > 0)
                {
                    nextNode = visited.Dequeue();
                    currentLevelNodes.Add(nextNode.val);
                    if (nextNode.left != null)
                    {
                        visited.Enqueue(nextNode.left);
                    }
                    if (nextNode.right != null)
                    {
                        visited.Enqueue(nextNode.right);
                    }
                    nodeCount--;

                }
                if (!leftToRight)
                    currentLevelNodes.Reverse();
                leftToRight = !leftToRight;
                LevelTraversedNodes.Add(currentLevelNodes);
            }
            return LevelTraversedNodes;
        }
    }
}
