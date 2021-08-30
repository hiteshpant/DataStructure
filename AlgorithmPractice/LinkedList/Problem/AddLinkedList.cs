using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.LinkedList.Problem
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class AddLinkedList
    {
        public ListNode AddLinkdeList(ListNode l1, ListNode l2)
        {
            ListNode dummyNode = new ListNode(0);
            var currentNode = dummyNode;

            int carry = 0;
            int sum = 0;
            while (l1 != null || l2 != null)
            {
                int val2 = l2 == null ? 0 : l2.val;
                int val1 = l1 == null ? 0 : l1.val;
                sum = val1 + val2 + carry;
                carry = sum > 9 ? 1 : 0;
                sum = sum > 9 ? sum % 10 : sum;
                currentNode.next = new ListNode(sum);
                currentNode = currentNode.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (carry == 1)
            {
                currentNode.next = new ListNode(1);
            }

            return dummyNode.next;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Stack<int> l1Copy = new Stack<int>();
            Stack<int> l2Copy = new Stack<int>();
            ListNode previousNode = null;
            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                    l1Copy.Push(l1.val);
                if (l2 != null)
                    l2Copy.Push(l2.val);
                l1 = l1?.next;
                l2 = l2?.next;
            }
            int val1, val2 = 0;

            int carry = 0, sum = 0;
            while (l1Copy.Count > 0 || l2Copy.Count > 0)
            {
                val1 = l1Copy.Count > 0 ? l1Copy.Pop() : 0;
                val2 = l2Copy.Count > 0 ? l2Copy.Pop() : 0;
                sum = val1 + val2 + carry;
                carry = sum > 9 ? 1 : 0;
                sum = sum > 9 ? sum % 10 : sum;
                ListNode node = new ListNode(sum);

                if (previousNode == null)
                {
                    previousNode = node;
                }
                else
                {
                    node.next = previousNode;
                    previousNode = node;
                }

            }

            if (carry == 1)
            {
                ListNode node = new ListNode(1);
                node.next = previousNode;
                previousNode = node;
            }

            return previousNode;
        }


        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode l1Pointer = headA;
            var l2Pointer = headB;
            while ((l1Pointer != null || l2Pointer != null) && l1Pointer != l2Pointer)
            {
                if (l1Pointer == null)
                {
                    l1Pointer = headB;
                }
                else
                    l1Pointer = l1Pointer.next;

                if (l2Pointer == null)
                {
                    l2Pointer = headA;
                }
                else
                    l2Pointer = l2Pointer.next;
            }
            return l1Pointer;


        }
    }
}

