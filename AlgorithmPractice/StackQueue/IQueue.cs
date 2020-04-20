using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.StackQueue
{
    public interface IQueue<T>
    {
        void Enqueue(T Data);

        T Dequeue();

        int Size { get; }
    }
}
