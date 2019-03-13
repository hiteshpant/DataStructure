using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.StackQueue
{
    public class SingleArrayThreeStack<T> : IStack<T>
    {

        private readonly int length;
        private readonly int stack1Size;
        private readonly int stack2Size;
        private readonly int stack3Size;
        private readonly T[] input = new T[] { };
        private readonly int[] topIndex;

        public SingleArrayThreeStack(T[] input)
        {
            this.input = input;
            length = input.Length;
            stack1Size = length / 3 - 1;
            stack2Size = length / 3 - 1;
            stack3Size = length / 3 - 1;
            topIndex = new int[3] { 0, stack1Size + 1, stack2Size + 1 };
        }

        public bool Push(T value, ArrayIndex stackIndex)
        {
            var result = false;
            if (topIndex[0] < stack1Size || topIndex[1] < stack2Size || topIndex[2] < stack3Size)
            {
                result = true;
                input[topIndex[(int)stackIndex] + 1] = value;
                topIndex[(int)stackIndex]++;
            }
            else
                throw new Exception("Stack is full cannot insert values");

            return result;
        }

        public bool Pop(ArrayIndex stackIndex)
        {
            bool result = false;
            if (topIndex[0] > 0 || topIndex[1] > 0 || topIndex[2] > 0)
            {

                input[topIndex[(int)stackIndex]] = default(T);
                topIndex[(int)stackIndex]--;
                result = true;
            }

            else
            {
                result = true;
                throw new Exception("All stacks are empty");
            }
            return result;
        }

        public T Peek(ArrayIndex stackIndex)
        {
            int index = (int)stackIndex * stack1Size + topIndex[(int)stackIndex];
            return input[index];
        }

      
    }


}
