using AlgorithmPractice.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.StackQueue
{
    public class StackFromLinkedList<T>
    {
        public Node<T> Top { get; private set; }
        public int Size { get; private set; }

        public StackFromLinkedList()
        {

        }

        public T Pop()
        {
            Node<T> previousNode = null;
            if (Top != null)
            {
                previousNode = Top.Next;
                Top = previousNode;
                Size--;
            }
            else
            {
                throw new Exception("Stack is empty");
            }
            return previousNode.Data;
        }


        public T Push(T data)
        {
            var newNode = new Node<T>(data);

            if (Top != null)
            {
                //connect new node to t
                newNode.Next = Top;
                Top = newNode;
            }
            else
                Top = newNode;
            Size++;
            return newNode.Data;
        }
    }



}
