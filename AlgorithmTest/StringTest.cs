using AlgorithmPractice;
using AlgorithmPractice.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    [TestClass]
    public class StringTest
    {
        private LongestSubstrinProblem _UniqueStringChecker;

        [TestInitialize]
        public void inititalize()
        {
            _UniqueStringChecker = new LongestSubstrinProblem();
        }

        [TestMethod]
        public void TestLongestSubstring()
        {
            var result = _UniqueStringChecker.OptimizedGetLongestSubstringlength(new StringBuilder("pwwke"));
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestLongestSubstringforSpace()
        {
            var result = _UniqueStringChecker.GetLongestSubstringlength(new StringBuilder("bbbbbb"));
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestReplaceWith()
        {
            var result = StringReplace.ReplaceString("My Name is Hitesh ");
            Assert.AreEqual(result.ToString(), "My%20Name%20is%20Hitesh%20");
        }
    }
}
