using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.LinkedList
{
    public class SingleLinkedlistOperation
    {
        public void InsertAtFront<T>(SinglyLinkedList<T> singlelist, T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = singlelist.Head;
            singlelist.Head = newNode;
        }

        public void InsertAtEnd<T>(SinglyLinkedList<T> singlelist, T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (singlelist.Head == null)
            {
                singlelist.Head = newNode;
                return;
            }

            GetLastNode(singlelist).Next = newNode;
            newNode.Next = null;
        }

        public void InsertAfter<T>(Node<T> prevNode, T data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("given previous Data cannot be null");
                return;
            }

            var newNode = new Node<T>(data);
            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
        }

        public void DeleteNodeByKey<T>(SinglyLinkedList<T> singleList, T data)
        {
            Node<T> previousNode = null;
            var temp = singleList.Head;
            while (temp != null)
            {
                if (temp.Data.Equals(data))
                {
                    if (previousNode != null)
                        previousNode.Next = temp.Next;
                    else
                        singleList.Head = temp.Next;
                    return;
                }
                previousNode = temp;
                temp = temp.Next;
            }
        }

        public SinglyLinkedList<T> ReverseLinkeList<T>(SinglyLinkedList<T> singleList)
        {
            Node<T> next = null;
            Node<T> previous = null;
            Node<T> current = singleList.Head;
            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            singleList.Head = previous;
            return singleList;
        }


        private Node<T> GetLastNode<T>(SinglyLinkedList<T> singlelist)
        {
            var tempNode = singlelist.Head;

            while (tempNode.Next != null)
                tempNode = tempNode.Next;

            return tempNode;
        }

        public Node<T> GetAllItemfromNthLocation<T>(SinglyLinkedList<T> list, int startIndex)
        {
            var currentListPointer = list.Head;
            for (int i = 1; i < startIndex; i++)
            {
                if (currentListPointer != null)
                    currentListPointer = currentListPointer.Next;
                else
                    Console.WriteLine("nth location is greater than list size itself");
            }

            return currentListPointer;
        }


        public Node<T> GetStartOfTheLoop<T>(SinglyLinkedList<T> singlelist)
        {
            var slowPointer = singlelist.Head;
            Node<T> fastPointer = singlelist.Head; ;
            bool IsLinkedListCyclic;
            while (fastPointer.Next != null && slowPointer != fastPointer)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next.Next;
            }

            if (fastPointer.Next == null)
                IsLinkedListCyclic = false;
            else
                IsLinkedListCyclic = true;

            slowPointer = singlelist.Head;
            while (IsLinkedListCyclic && slowPointer != fastPointer)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next;
            }
            return IsLinkedListCyclic == true ? fastPointer : null;
        }

        public Node<T> RemoveNthFromEnd<T>(Node<T> head, int n)
        {
            int length = 0;
            var tempNode = head;
            var tempNode2 = head;
            while (tempNode != null)
            {
                tempNode = tempNode.Next;
                length++;
            }

            int indexToBeRemoved = length - n;
            int counter = 0;
            if (indexToBeRemoved == -1)
                return head = head.Next;
            while (tempNode2 != null)
            {
                counter++;
                if (counter == indexToBeRemoved)
                {
                    tempNode2.Next = tempNode2.Next?.Next;
                    break;
                }
                else
                    tempNode2 = tempNode2.Next;

            }
            return head;

        }


        public Node<T> RemoveNthFromEndOpt<T>(Node<T> head, int n)
        {
            var slowPointer = head;
            var FastPointer = head;

            for (int i = 0; i < n; i++)
            {
                FastPointer = FastPointer.Next;
            }

            while (FastPointer.Next != null)
            {
                slowPointer = slowPointer.Next;
                FastPointer = FastPointer.Next;
            }

            slowPointer.Next = slowPointer.Next?.Next;

            return head;
        }
    }

    public class SolutionMerge
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

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var ListNode = new ListNode(0);
            var currentNode = ListNode;


            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    currentNode.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    currentNode.next = l2;
                    l2 = l2.next;
                }
                currentNode = currentNode.next;
            }

            if (l1 != null)
            {
                currentNode.next = l1;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                currentNode.next = l2;
                l2 = l2.next;
            }

            return ListNode.next;

        }

        /// <summary>
        /// Merges K List into one list using divide and conquer approach
        /// </summary>
        /// <param name="lists"></param>
        /// <returns></returns>
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
                return null;
            int last = lists.Length - 1;

            // repeat until only one list is left 
            while (last != 0)
            {
                int i = 0, j = last;

                // (i, j) forms a pair 
                while (i < j)
                {
                    // merge List i with List j and store 
                    // merged list in List i 
                    lists[i] = MergeTwoLists(lists[i], lists[j]);

                    // consider next pair 
                    i++;
                    j--;

                    // If all pairs are merged, update last 
                    if (i >= j)
                        last = j;
                }
            }

            return lists[0];
        }
    }

}
