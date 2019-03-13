using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.StackQueue
{
    public class SetOfStacks<T>
    {
        public Dictionary<int, StackFromLinkedList<T>> StackRepo
        { get; private set; } = new Dictionary<int, StackFromLinkedList<T>>();
        public int Thresold { get; }

        public int Top { get; private set; }

      

        public SetOfStacks(int thersold)
        {
            Thresold = thersold;
        }

        public T Push(T Data)
        {
            T result = default(T);
            if (StackRepo.ContainsKey(Top))
            {
                if (StackRepo[Top].Size == Thresold)
                {
                    Top++;
                    AddNewStack(Top);
                }
                result = StackRepo[Top].Push(Data);
            }
            else
            {
                AddNewStack(Top);
                result = StackRepo[Top].Push(Data);
            }
            return result;
        }

        private void AddNewStack(int top)
        {
            StackRepo[Top] = new StackFromLinkedList<T>();
        }

        public T Pop()
        {
            var stack = StackRepo[Top];
            if (stack != null)
                return stack.Pop();
            else
                throw new Exception("stack is empty");
        }

    }
}
