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

        [TestMethod]
        public void TestLexographicSolution()
        {
            LexographicSolution sol = new LexographicSolution();
            string[] logFiles = new string[]
            {
                "6p tzwmh ige mc", "ns 566543603829", "ubd cujg j d yf",
                "ha6 1 938 376 5", "3yx 97 666 56 5", "d 84 34353 2249",
                "0 tllgmf qp znc", "s 1088746413789", "ys0 splqqxoflgx",
                "uhb rfrwt qzx r", "u lrvmdt ykmox", "ah4 4209164350",
                "rap 7729 8 125", "4 nivgc qo z i", "apx 814023338 8" };

            sol.ReorderLogFiles(logFiles);



          //string[] output = new string[]
          //{
          //    "ubd cujg j d yf","u lrvmdt ykmox","4 nivgc qo z i",
          //     "uhb rfrwt qzx r","ys0 splqqxoflgx","0 tllgmf qp znc",
          //      "6p tzwmh ige mc","ns 566543603829","ha6 1 938 376 5",
          //      "3yx 97 666 56 5","d 84 34353 2249","s 1088746413789",
          //  "ah4 4209164350","rap 7729 8 125","apx 814023338 8"}
        var result = StringReplace.ReplaceString("My Name is Hitesh ");
            Assert.AreEqual(result.ToString(), "My%20Name%20is%20Hitesh%20");
        }
    }
}
