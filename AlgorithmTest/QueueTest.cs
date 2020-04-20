using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice.StackQueue;
using System.Diagnostics;

namespace AlgorithmTest
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void TestQueueEnqueueFromLL()
        {
            QueueFromLL<int> queue = new QueueFromLL<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.AreEqual(1, queue.Front.Data);

        }


    }
}
