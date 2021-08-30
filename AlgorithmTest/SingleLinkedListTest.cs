using System;
using AlgorithmPractice.LinkedList;
using AlgorithmPractice.LinkedList.Problem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ValidParanthesesSolution;

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

        [TestMethod]
        public void TestRemoveNthFromEnd()
        {
            var operation = new SingleLinkedlistOperation();

            Node<int> node = new Node<int>(1);
            node.Next = new Node<int>(2);
            node.Next.Next = new Node<int>(3);
            node.Next.Next.Next = new Node<int>(4);
            node.Next.Next.Next.Next = new Node<int>(5);

            var curentNode = operation.RemoveNthFromEndOpt<int>(node, 2);
            Assert.AreEqual(curentNode.Data, 3);
        }

        [TestMethod]
        public void TestMergeTwoLists()
        {
            var merge = new SolutionMerge();


            var list1 = new SolutionMerge.ListNode(1);
            list1.next = new SolutionMerge.ListNode(2);
            list1.next.next = new SolutionMerge.ListNode(4);

            var list2 = new SolutionMerge.ListNode(1);
            list2.next = new SolutionMerge.ListNode(3);
            list2.next.next = new SolutionMerge.ListNode(4);


            var curentNode = merge.MergeTwoLists(list1, list2);
        }

        [TestMethod]
        public void TestLinkedListSum()
        {
            AddLinkedList sol = new AddLinkedList();
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);


            ListNode output = new ListNode(7);
            output.next = new ListNode(0);
            output.next.next = new ListNode(8);

            var result = sol.AddLinkdeList(l1, l2);

            CollectionAssert.Equals(result, output);


        }

        [TestMethod]
        public void TestAdLinkedList()
        {
            AddLinkedList sol = new AddLinkedList();
            ListNode l1 = new ListNode(7);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);


            ListNode output = new ListNode(7);
            //output.next = new ListNode(8);
            //output.next.next = new ListNode(0);
            //output.next.next.next= new ListNode(7);

            var result = sol.AddTwoNumbers(l1, output);

            CollectionAssert.Equals(result, output);
        }

        [ClassCleanup]
        public static void CleanUpResource()
        {
            _SinglelinkeList = null;
        }
    }
}
