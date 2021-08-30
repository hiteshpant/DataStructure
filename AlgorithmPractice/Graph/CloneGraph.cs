using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Graph
{
    // Definition for a Node.
    class Node
    {
        public int val;
        public List<Node> neighbors;

        public Node() { }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    };

    class Solution
    {
        public Node cloneGraph(Node node)
        {
            if (node == null)
            {
                return node;
            }
            
            Dictionary<Node, Node> visited = new Dictionary<Node,Node>();           
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            visited.Add(node, new Node(node.val, new List<Node>()));

            while (queue.Count>0)
            {
                Node n = queue.Dequeue();
                foreach (Node neighbor in  n.neighbors)
                {
                    if (!visited.ContainsKey(neighbor))
                    {
                        visited[neighbor] = new Node(neighbor.val, new List<Node>());
                        queue.Enqueue(neighbor);
                    }
                    visited[n].neighbors.Add(visited[neighbor]);
                }
            }
            return visited[node];
        }
    }
}
