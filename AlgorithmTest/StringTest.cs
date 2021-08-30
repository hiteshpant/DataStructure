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
            var result = _UniqueStringChecker.OptimizedGetLongestSubstringlength1("pwwke");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestLongestSubstringforSpace()
        {
            var result = _UniqueStringChecker.OptimizedGetLongestSubstringlength1("abcabcbb");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestReplaceWith()
        {
            var result = StringReplace.ReplaceString("My Name is Hitesh ");
            Assert.AreEqual(result.ToString(), "My%20Name%20is%20Hitesh%20");
        }

        [TestMethod]
        public void TesetValidPalindrome()
        {
            PalindromSol sol = new PalindromSol();
            var result = sol.ValidPalindrome("pidbliassaqozokmtgahluruufwbjdtayuhbxwoicviygilgzduudzgligyviciowxbhuyatdjbwfuurulhagtmkozoqassailbdip");

            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void TesetValidPalindromeSol2TrueCase()
        {
            var sol2 = new PalindromSol2();
            var result = sol2.IsPalindrome("A man, a plan, a canal: Panama");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestReverseString()
        {
            var sol2 = new PalindromSol2();

            var result = sol2.ReverseWords("    the    sky    is   blue    ");

            Assert.AreEqual(result, "blue is sky the");
        }


        [TestMethod]
        public void TesetValidPalindromeSol2FalseCase()
        {
            var sol2 = new PalindromSol2();
            var result = sol2.IsPalindrome("0P");

            Assert.AreEqual(false, result);
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

        [TestMethod]
        public void CheckAtoi()
        {
            var sol = new AtoiSolution();
            //var result = sol.MyAtoi("-91283472332");  
            //Assert.IsTrue(result == Int32.MinValue);

            //result = sol.MyAtoi("4193 with words");
            //Assert.IsTrue(result == 4193);

            //result = sol.MyAtoi("words and 987");
            //Assert.IsTrue(result == 0);

            //result = sol.MyAtoi("   -42");
            //Assert.IsTrue(result == -42);

            //result = sol.MyAtoi("   -04f");
            //Assert.IsTrue(result == -4);

            //result = sol.MyAtoi("+");
            //Assert.IsTrue(result == 0);

            //result = sol.MyAtoi("-");
            //Assert.IsTrue(result == 0);


            //result = sol.MyAtoi("  -0012a42");
            //Assert.IsTrue(result == -12);


            //result = sol.MyAtoi("1a");
            //Assert.IsTrue(result == 1);

            var result = sol.MyAtoi("   -115579378e25");
            Assert.IsTrue(result == -5);
        }

        [TestMethod]

        public void CheckSubDomainVisit()
        {
            //var subDomainVists= new SubDomainVisits();
            //var result = subDomainVists.SubdomainVisits(new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" });
        }


        [TestMethod]
        public void LongestPalindromeCheck()
        {
            var subDomainVists = new LongestPalindromeSol();
            var result = subDomainVists.LongestPalindrome("abccccdd");
        }

        [TestMethod]
        public void TestReverseCharArray()
        {
            var sol = new Solution();
            var input = new char[] { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' };
            sol.ReverseWords(input);
            var output = new char[] { 'b', 'l', 'u', 'e', ' ', 'i', 's', ' ', 's', 'k', 'y', ' ', 't', 'h', 'e' };
            CollectionAssert.AreEqual(input, output);

        }

        [TestMethod]

        public void TestLongestPalindrome()
        {
            var sol = new LongestPalindromeSubstring();
            var output = sol.longestPalindrome("babad");
            Assert.AreEqual(output, "bab");
        }


        [TestMethod]
        public void TestLongestCommonSubsequence()
        {
            LongestCommonSubsequence lcs = new LongestCommonSubsequence();
            var output = lcs.PrintLongestCommonSubsequence("AGGTAB", "GXTXAYB");

            Assert.AreEqual(output, "GTAB");

        }

        [TestMethod]

        public void TestLongestIncreasingSunsequence()
        {
            var sol = new LisSolution();
            var result = sol.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 4 });
            Assert.AreEqual(4, result);
        }
    }
}
