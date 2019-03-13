using System;
using System.Text;
//Definition for singly-linked list.

namespace AddList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        private ListNode l1;
        private ListNode l2;

        public Solution()
        {
            l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);
        }

        public ListNode AddTwoNumbers(/*ListNode l1, ListNode l2*/)
        {
            StringBuilder l1Buffer = new StringBuilder();
            while (l1 != null)
            {
                l1Buffer.Append(l1.val);
                l1 = l1.next;
            }

            StringBuilder l2Buffer = new StringBuilder();
            while (l2 != null)
            {
                l2Buffer.Append(l2.val);
                l2 = l2.next;
            }

            double list1 = l1Buffer.Length > 0 ? double.Parse(l1Buffer.ToString()) : 0;
            double list2 = l2Buffer.Length > 0 ? long.Parse(l2Buffer.ToString()) : 0;
            StringBuilder sumString = new StringBuilder();
            int carryForward = 0;
            for (int i = 0, j = 0; i < l1Buffer.Length || j < l2Buffer.Length; i++, j++)
            {
                int l1Value = 0;
                int l2Value = 0;
                if (l1Buffer.Length > i)
                    l1Value = int.Parse(l1Buffer[i].ToString() != null ? l1Buffer[i].ToString() : "0");
                else
                    l1Value = 0;

                if (l2Buffer.Length > j)
                    l2Value = int.Parse(l2Buffer[j].ToString() != null ? l2Buffer[j].ToString() : "0");
                else
                    l2Value = 0;

                int totalSum = l1Value + l2Value + carryForward;
                carryForward = totalSum >= 10 ? 1 : 0;
                totalSum = totalSum >= 10 ? totalSum - 10 : totalSum;             
                sumString.Append(totalSum);
            }
            if (carryForward == 1)
                sumString.Append(1);
            ListNode resultNode = GenerateLinkedList(sumString);
            return resultNode;
        }

        private ListNode GenerateLinkedList(StringBuilder sumString)
        {
            ListNode resultNode = new ListNode(int.Parse
                            (sumString[0].ToString()));
            for (int k = 1; k < sumString.Length; k++)
            {
                ListNode newNode = new ListNode(int.Parse(sumString[k].ToString()));
                GetLastNode(resultNode).next = newNode;
            }

            return resultNode;
        }

        private ListNode GetLastNode(ListNode listNode)
        {
            ListNode tempNode = listNode;
            while (tempNode.next != null)
                tempNode = tempNode.next;
            return tempNode;
        }
    }
}