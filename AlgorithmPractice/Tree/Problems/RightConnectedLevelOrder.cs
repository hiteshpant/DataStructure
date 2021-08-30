using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tree.Problems
{
    //Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }


    public class RightConnectLecelOrderSolution
    {
        public Node Connect(Node root)
        {
            Queue<Node> _Visited = new Queue<Node>();
            _Visited.Enqueue(root);
            int nodeCount = 0;
            Queue<Node> rightNodeItems = new Queue<Node>();
            while (true)
            {
                nodeCount = _Visited.Count;
                if (nodeCount == 0)
                {
                    break;
                }
                rightNodeItems?.Clear();
                while (nodeCount > 0)
                {
                    var peekedItem = _Visited.Dequeue();
                    rightNodeItems.Enqueue(peekedItem);
                    if (peekedItem?.left != null)
                    {
                        _Visited.Enqueue(peekedItem?.left);
                    }
                    if (peekedItem.right != null)
                    {
                        _Visited.Enqueue(peekedItem?.right);
                    }
                    nodeCount--;
                }

                while (rightNodeItems.Count > 0)
                {
                    var popedItem = rightNodeItems.Dequeue();
                    popedItem.next = new Node();
                    popedItem.next = rightNodeItems.Count > 0 ? rightNodeItems?.Peek() : null;
                }
            }
            return root;
        }
    }
}
