using AlgorithmPractice.StackQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    [TestClass]
    public class SetOfStacksTest
    {
        [TestMethod]
        public void TestSetOfStackPush()
        {
            SetOfStacks<int> setOfStack = new SetOfStacks<int>(3);
            setOfStack.Push(1);
            setOfStack.Push(2);
            setOfStack.Push(3);
            setOfStack.Push(4);

            Assert.AreEqual(setOfStack.StackRepo.Count, 2);
        }

        [TestMethod]
        public void TestStackFromLinkedListPush()
        {
            StackFromLinkedList<int> stack = new StackFromLinkedList<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.AreEqual(3, stack.Top.Data);
        }

        [TestMethod]
        public void CheckThreeStackOperation()
        {

            ThreeeStackFromSingleArrayOptimized<int> obj = new ThreeeStackFromSingleArrayOptimized<int>
            (9, 3);
            obj.Push(1, 0);
            obj.Push(2, 1);
            obj.Push(3, 2);
            obj.Push(4, 0);
            obj.Push(5, 1);
            obj.Push(6, 2);
            obj.Push(7, 0);
            obj.Push(8, 1);
            obj.Push(9, 0);

            //Stack1 1,7,9)
            //stack2 2,4,7
            //stack3 3,6

            obj.Pop(0);
            obj.Pop(0);
            obj.Pop(0);

            obj.Pop(1);
            obj.Pop(1);
            obj.Pop(1);

            obj.Pop(2);
            obj.Pop(2); 


        }
    }
}
