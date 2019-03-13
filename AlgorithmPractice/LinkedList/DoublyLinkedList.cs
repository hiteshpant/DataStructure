using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.LinkedList
{
    public class DoublyLinkedListOPeration<T>
    {
        public void InsertAtFront<T>(DoublyLinkedList<T> list, T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            newNode.Next = list.Head;
            newNode.Previous = null;
            if (list.Head != null)
            {
                list.Head.Previous = newNode;
            }
            list.Head = newNode;
        }
        public void InsertAtEnd<T>(DoublyLinkedList<T> list, T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            var lastNode = GetLastNode(list);
            lastNode.Next = newNode;
            newNode.Previous = lastNode;
        }

        public void InsertAfter<T>(DoublyNode<T> prevNode, T data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("given previous Data cannot be null");
                return;
            }
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
            newNode.Previous = prevNode;
        }

        public void Delete<T>(DoublyLinkedList<T> list, T data)
        {
            var temp = list.Head;
            bool result = false;

            if (temp != null && temp.Data.Equals(data))
            {
                list.Head = temp.Next;
                if (list.Head!= null)
                    list.Head.Previous = null;
                return;
            }   


            while (temp != null)
            {
                if (temp.Data.Equals(data))
                {
                    temp.Next.Previous = temp.Previous;
                    temp.Previous.Next = temp.Next;
                    result = true;
                    break;
                }
                else
                    temp = temp.Next;
            }
            if (result == false)
                throw new Exception("Element Not Found");
        }

        public void ReverseList(DoublyLinkedList<T> list)
        {
            var current = list.Head;
            DoublyNode<T> previousNode=null;
            DoublyNode<T> nextNode;
            while(current.Next != null)
            {
                nextNode = current.Next;
                current.Next = previousNode;
                current.Next.Previous  = 
                previousNode = current;
                current = nextNode;
            }
        }

        private DoublyNode<T> GetLastNode<T>(DoublyLinkedList<T> list)
        {
            var tempNode = list.Head;
            while (tempNode.Next != null)
                tempNode = tempNode.Next;
            return tempNode;
        }
    }
}
