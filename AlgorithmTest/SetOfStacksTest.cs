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
    }
}
