using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Serialization is the process of converting a data structure or object into a sequence of bits so that it can be stored in a
//file or memory buffer, or transmitted across a network connection link to be reconstructed later in the same or another computer environment.
//Design an algorithm to serialize and deserialize a binary tree.
//There is no restriction on how your serialization/deserialization algorithm should work. 
//You just need to ensure that a binary tree can be serialized to a string and this string can be deserialized to the original tree structure.

//Example: 

//You may serialize the following tree:

//    1
//   / \
//  2   3
//     / \
//    4   5

//as "[1,2,3,null,null,4,5]"

namespace AlgorithmPractice.Tree.Problems
{

    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Codec
    {

        // Encodes a tree to a single string.
        public string Serialize(TreeNode root)
        {          
            if (root == null)
                return "";

            StringBuilder result = new StringBuilder();

            // Create queue
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            // Run loop while queue is not empty
            while (q.Count > 0)
            {
                // Dequeue node
                var node = q.Dequeue();
                string value = node == null ? "null," : node.val.ToString() + ",";
                // Add node val to string
                result.Append(value);

                // Enqueue leaf nodes
                if (node != null)
                {
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }

            return result.ToString();
        }

        //    1
        //   / \
        //  2   3
        //     / \
        //    4   5
        // Decodes your encoded data to tree.
        public TreeNode Deserialize(string data)
        {
            var inputData = data.Split(',');

            var root = GetTreeNodeFromString(inputData[0]);
            Queue<TreeNode> _StackNodes = new Queue<TreeNode>();
            _StackNodes.Enqueue(root);
            for (int i = 1; i < inputData.Length && _StackNodes.Count > 0; i += 2)
            {
                // Get node at front of queue
                var node = _StackNodes.Dequeue();

                // Create leaves
                node.left = GetTreeNodeFromString(inputData[i]);
                node.right = GetTreeNodeFromString(inputData[i + 1]);

                // If leaves are not null, enqueue'em to continue BFS down their path
                if (node.left != null)
                {
                    _StackNodes.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    _StackNodes.Enqueue(node.right);
                }              

            }
            return root;
        }
       

        private TreeNode GetTreeNodeFromString(string data)
        {
            if (Int32.TryParse(data, out int result))
                return new TreeNode(result);
            else
                return null;
        }
    }

}
