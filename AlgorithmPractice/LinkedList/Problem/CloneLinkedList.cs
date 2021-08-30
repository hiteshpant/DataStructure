using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.LinkedList.Problem
{

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }


    public class CloneLinkedListSolution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;
            var current = head;
            while (current != null)
            {
                Node tempNode = new Node(current.val);
                tempNode.next = current.next;
                current.next = tempNode;
                current = current.next?.next;
            }

            current = head;
            while (current != null)
            {
                current.next.random = current.random?.next;
                current = current?.next?.next;
            }

            Node copy = new Node(0);
            Node iterator = copy;
            current = head;
            while (current != null)
            {
                iterator.next = current.next;
                iterator = iterator.next;
                current.next = current.next.next;
                current = current.next;
            }

            return copy.next;
        }
    }

}
