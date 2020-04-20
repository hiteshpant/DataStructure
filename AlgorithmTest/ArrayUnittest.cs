using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice.Array;

namespace AlgorithmTest
{
    [TestClass]
    public class ArrayUnittest
    {
        [TestMethod]
        public void TestNoOfIsland()
        {

            char[][] input = new char[4][]
            {
             new char[5]{'1', '1', '0','0','0' },
             new char[5]{'1', '1','0' ,'0' ,'0' },
             new char[5]{'0', '0','1' ,'0' ,'0' },
             new char[5]{'0', '0','0' ,'1' ,'1' },
            };

            Solution sln = new Solution();
            Assert.AreEqual(2, sln.NumIslands(input));
        }
    }
}
