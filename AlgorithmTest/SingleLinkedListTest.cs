using System;
using AlgorithmPractice.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTest
{
    [TestClass]
    public class SingleLinkedListTest
    {
        private static SinglyLinkedList<int> _SinglelinkeList;

        [TestInitialize]
        public void Initialize()
        {
            _SinglelinkeList = new SinglyLinkedList<int>();
            _SinglelinkeList.Head = new Node<int>(1);
            _SinglelinkeList.Head.Next = new Node<int>(2);
            _SinglelinkeList.Head.Next.Next = new Node<int>(3);
            _SinglelinkeList.Head.Next.Next.Next = new Node<int>(4);
        }

        [TestMethod]
        public void TestInsertAtFront()
        {
            SingleLinkedlistOperation operation = new SingleLinkedlistOperation();
            operation.InsertAtFront(_SinglelinkeList, 5);
            Assert.AreEqual(_SinglelinkeList.Head.Data, 5);
        }

        [TestMethod]
        public void TestInsertAtEnd()
        {
            SingleLinkedlistOperation operation = new SingleLinkedlistOperation();
            operation.InsertAtEnd(_SinglelinkeList, 5);
            Assert.AreEqual(GetLastNode(_SinglelinkeList).Data, 5);
        }

        [TestMethod]
        public void TestInsertAfter()
        {
            SingleLinkedlistOperation operation = new SingleLinkedlistOperation();
            operation.InsertAfter<int>(_SinglelinkeList.Head.Next.Next, 5);
            Assert.AreEqual(_SinglelinkeList.Head.Next.Next.Next.Data, 5);
        }

        [TestMethod]
        public void TestDelete()
        {
            SingleLinkedlistOperation operation = new SingleLinkedlistOperation();
            operation.DeleteNodeByKey<int>(_SinglelinkeList, 3);
            Assert.AreEqual(_SinglelinkeList.Head.Next.Next.Data, 4);
        }

        [TestMethod]
        public void ReverseLinkedList()
        {
            SingleLinkedlistOperation operation = new SingleLinkedlistOperation();
            var reversedList = operation.ReverseLinkeList(_SinglelinkeList);
            Assert.AreEqual(_SinglelinkeList.Head.Data, 4);
        }

        private Node<int> GetLastNode(SinglyLinkedList<int> singlelinkeList)
        {
            var tempNode = singlelinkeList.Head;
            while (tempNode.Next != null)
                tempNode = tempNode.Next;
            return tempNode;
        }

        [TestMethod]
        public void TestCyclicNode()
        {
            _SinglelinkeList = new SinglyLinkedList<int>();
            _SinglelinkeList.Head = new Node<int>(1);
            _SinglelinkeList.Head.Next = new Node<int>(2);
            var cyclicNode = new Node<int>(3);
            _SinglelinkeList.Head.Next.Next = cyclicNode;
            _SinglelinkeList.Head.Next.Next.Next = new Node<int>(4);
            _SinglelinkeList.Head.Next.Next.Next.Next = cyclicNode;
            SingleLinkedlistOperation operation = new SingleLinkedlistOperation();

            var node = operation.GetStartOfTheLoop(_SinglelinkeList);
            Assert.AreEqual(node.Data, 3);
        }

        [TestMethod]
        public void TestNonCyclicNode()
        {
            _SinglelinkeList = new SinglyLinkedList<int>();
            _SinglelinkeList.Head = new Node<int>(1);
            _SinglelinkeList.Head.Next = new Node<int>(2);
            var cyclicNode = new Node<int>(3);
            _SinglelinkeList.Head.Next.Next = cyclicNode;
            _SinglelinkeList.Head.Next.Next.Next = new Node<int>(4);
            SingleLinkedlistOperation operation = new SingleLinkedlistOperation();

            var node = operation.GetStartOfTheLoop(_SinglelinkeList);
            Assert.IsNull(node);
        }


        [TestMethod]
        public void TestGetListFromNthLocation()
        {
            SingleLinkedlistOperation operation = new SingleLinkedlistOperation();
            var curentNode = operation.GetAllItemfromNthLocation(_SinglelinkeList, 3);
            Assert.AreEqual(curentNode.Data, 3);
        }

        [ClassCleanup]
        public static void CleanUpResource()
        {
            _SinglelinkeList = null;
        }
    }
}
