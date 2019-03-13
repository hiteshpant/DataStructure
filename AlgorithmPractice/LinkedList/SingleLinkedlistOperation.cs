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
    }
}
