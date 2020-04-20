using AlgorithmPractice.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.StackQueue
{
    public class QueueFromLL<T> : IQueue<T>
    {
        public Node<T> Front { get; private set; }
        public Node<T> Rear { get; private set; }
        public int Size { get; private set; }

        public T Dequeue()
        {
            T removedData = default(T);
            if (Front != null)
            {
                removedData = Front.Data;
                Front = Front.Next;
                Size--;
            }
            else
            {
                throw new Exception("Queue is Empty");
            }
            return removedData;
        }

        public void Enqueue(T data)
        {
            if (Front != null)
            {
                var newNode = new Node<T>(data);
                Rear.Next = newNode;
                Rear = newNode;
            }
            else
            {
                Front = new Node<T>(data);
                Rear = Front;
            }
            Size++;
        }
    }
}
