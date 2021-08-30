using AlgorithmPractice.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cloneLinkedList = AlgorithmPractice.LinkedList.Problem;

namespace AlgorithmTest
{
    [TestClass]
    public class DoubleLinkedListTest
    {
        private DoublyLinkedList<int> _DoublelinkedList;

        [TestInitialize]
        public void Initialize()
        {
            _DoublelinkedList = new DoublyLinkedList<int>();
            _DoublelinkedList.Head = new DoublyNode<int>(2);

            _DoublelinkedList.Head.Previous = null;
            _DoublelinkedList.Head.Next = new DoublyNode<int>(3);
            _DoublelinkedList.Head.Next.Previous = _DoublelinkedList.Head;

            _DoublelinkedList.Head.Next.Next = new DoublyNode<int>(4);
            _DoublelinkedList.Head.Next.Next.Previous = _DoublelinkedList.Head.Next;
        }


        [TestMethod]
        public void TestInsertAtFront()
        {
            DoublyLinkedListOPeration<int> doublyOperation = new DoublyLinkedListOPeration<int>();
            doublyOperation.InsertAtFront(_DoublelinkedList, 1);
            Assert.AreEqual(_DoublelinkedList.Head.Data, 1);
        }

        [TestMethod]
        public void TestInsertAtLast()
        {
            DoublyLinkedListOPeration<int> doublyOperation = new DoublyLinkedListOPeration<int>();
            doublyOperation.InsertAtEnd(_DoublelinkedList, 1);
            Assert.AreEqual(_DoublelinkedList.Head.Next.Next.Next.Data, 1);
            Assert.AreEqual(_DoublelinkedList.Head.Next.Data, 1);

        }

        [TestMethod]
        public void TestDelete()
        {
            DoublyLinkedListOPeration<int> doublyOperation = new DoublyLinkedListOPeration<int>();
            doublyOperation.Delete(_DoublelinkedList, 2);
            Assert.AreEqual(_DoublelinkedList.Head.Data, 3);
        }

        [TestMethod]
        public void TestCloneLinkedList()
        {
            cloneLinkedList.Node node = new cloneLinkedList.Node(7);
            node.next = new cloneLinkedList.Node(13);
            node.next.next = new cloneLinkedList.Node(11);
            node.next.next.next = new cloneLinkedList.Node(10);
            node.next.next.next.next = new cloneLinkedList.Node(1);

            node.random = null;
            node.next.random = node;
            node.next.next.random = node.next.next.next.next;
            node.next.next.next.random = node.next.next;
            node.next.next.next.next.random = node;
            cloneLinkedList.CloneLinkedListSolution sol = new cloneLinkedList.CloneLinkedListSolution();

            var cloneList = sol.CopyRandomList(node);

        }

    }
}
