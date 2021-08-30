using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.StackQueue
{
    public class StackWithMin : StackList<int>
    {
        StackList<int> _StackMinValue;
        public StackWithMin(int size)
        {
            _StackMinValue = new StackList<int>(size);
        }

        public override bool Pop(ArrayIndex stackIndex = 0)
        {
            var value = base.Peek();
            if (value == Min())
                _StackMinValue.Pop();
            return base.Pop();
        }

        public override bool Push(int value, ArrayIndex stackIndex = 0)
        {
            if (value <= Min())
                _StackMinValue.Push(value);
            return base.Push(value);
        }

        public int Min()
        {
            if (_StackMinValue.IsEmpty)
                return int.MaxValue;
            else
                return _StackMinValue.Peek();
        }
    }
}
