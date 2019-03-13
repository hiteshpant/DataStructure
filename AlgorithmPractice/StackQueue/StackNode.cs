using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Stack Implemtation with Array
namespace AlgorithmPractice.StackQueue
{
    public class StackNode
    {
        public int? Value { get; private set; }

        public int MaxValue { get;  set; }

        public StackNode(int value,int topIndex)
        {
            Value= value;
            MaxValue = value;
        }
    }

    public class StackList<T>:IStack<T>
    {
        private int _TopIndex=-1;
        private int _InitialSize;
        public T[] Nodes { get; private set; }


        public bool IsEmpty
        {
            get
            {
                return _TopIndex >= 0 ? true : false;
            }
        }

        public StackList(int initialSize=30)
        {
            _InitialSize = initialSize;
            Nodes = new T[_InitialSize];
        }

        public virtual bool Push(T value, ArrayIndex stackIndex=0)
        {
            if (_TopIndex > _InitialSize - 1)
                throw new Exception("Stack Overflow");
            else
            {
                Nodes[++_TopIndex] = value;
                return true;
            }            
        }

        public virtual bool Pop(ArrayIndex stackIndex=0)
        {
            if (_TopIndex == - 1)
                throw new Exception("Stack is empty");
            else
            {
                Nodes[_TopIndex] = default(T);
                return true;
            }

        }

        public T Peek(ArrayIndex stackIndex=0)
        {
            return Nodes[_TopIndex];
        }
    }
}
