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
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            IList<IList<int>> LevlTraversedNodes = new List<IList<int>>();
            nodes.Enqueue(root);
            TreeNode nextNode;
            List<int> currentLevelNodes;
            while (true)
            {
                int nodeCount = nodes.Count;
                if (nodeCount == 0)
                    break;
                currentLevelNodes = new List<int>();
                while (nodeCount > 0)
                {
                    nextNode = nodes.Peek();
                    nodes.Dequeue();
                    currentLevelNodes.Add(nextNode.val);
                    if (nextNode.left != null)
                    {
                        nodes.Enqueue(nextNode.left);
                    }
                    if (nextNode.right != null)
                    {
                        nodes.Enqueue(nextNode.right);
                    }
                    nodeCount--;
                }
                LevlTraversedNodes.Add(currentLevelNodes);
            }
            return LevlTraversedNodes;
        }
    }
}
