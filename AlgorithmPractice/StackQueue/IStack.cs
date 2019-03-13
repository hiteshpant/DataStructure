using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.StackQueue
{
    public interface IStack<T>  
    {
        bool Push(T value, ArrayIndex stackIndex);

        bool Pop(ArrayIndex stackIndex);

        T Peek(ArrayIndex stackIndex);
    }


    public enum ArrayIndex
    {
        One,
        Two,
        Three
    }
}
