using AlgorithmPractice.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    [TestClass]
    public class RemoveDulpicateTest
    {

        [TestMethod]
        public void TestGetUniqueArrayLength()
        {
            int[] input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            RemoveDuplicate removeDuplicate = new RemoveDuplicate();
            var result = removeDuplicate.GetUniqueArrayLength(input);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestGetUniqueArrayLengthForEmptyArray()
        {
            int[] input = new int[] { };

            RemoveDuplicate removeDuplicate = new RemoveDuplicate();
            var result = removeDuplicate.GetUniqueArrayLength(input);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestGetUniqueArrayLengthForDistinctElement()
        {
            int[] input = new int[] { 0, 1, 2, 3, 4 };

            RemoveDuplicate removeDuplicate = new RemoveDuplicate();
            var result = removeDuplicate.GetUniqueArrayLength(input);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestGetUniqueArrayLengthForSameArray()
        {
            int[] input = new int[] { 0, 0, 0, 0 };

            RemoveDuplicate removeDuplicate = new RemoveDuplicate();
            var result = removeDuplicate.GetUniqueArrayLength(input);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestGetTargetSum()
        {
            int[] input = new int[] { 2, 16, 11, 7 };

            TwoSum twoSum = new TwoSum();
            var result = twoSum.GetIndicesForSum(input, 9);
            Assert.AreEqual(new int[] { 0, 1 }, result);
        }
    }
}
