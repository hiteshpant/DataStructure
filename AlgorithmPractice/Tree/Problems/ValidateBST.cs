using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Given a binary tree, determine if it is a valid binary search tree(BST).

//Assume a BST is defined as follows:

//The left subtree of a node contains only nodes with keys less than the node's key.
//The right subtree of a node contains only nodes with keys greater than the node's key.
//Both the left and right subtrees must also be binary search trees.


//Example 1:

//    2
//   / \
//  1   3

//Input: [2,1,3]
//Output: true
namespace AlgorithmPractice.Tree.Problems
{
    public class validateBSTSol
    {

        private List<int> _FlatTree = new List<int>();
        private Stack<TreeNode> _StackOfNodes = new Stack<TreeNode>();
        int lastValue,isFirstTimePoped;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsValidBST(TreeNode root)
        {
            var currentNode = root;
            int lastValue = Int32.MaxValue;
            bool result = true;
            while (currentNode != null || _StackOfNodes.Count > 0)
            {              

                if (currentNode != null)
                {
                    _StackOfNodes.Push(currentNode);
                }
                currentNode = currentNode?.left;
                if (currentNode == null && _StackOfNodes.Count > 0)
                {
                    var popedItem = _StackOfNodes.Pop();
                    if (isFirstTimePoped ==0 || lastValue < popedItem.val)
                    {
                        isFirstTimePoped = 1;
                        lastValue = popedItem.val;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                    currentNode = popedItem?.right;
                }
            }
            return result;

        }


    }
}
