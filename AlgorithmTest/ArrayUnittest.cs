using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice.Array;
using AlgorithmPractice;

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

        [TestMethod]
        public void TestMatrixRotate()
        {
            ImageRotate rotate = new ImageRotate();
            int[][] matrix = new int[][]
            {
                new int[3] {1,2,3},
                new int[3]{4,5,6},
                new int[3]{7,8,9},
            };

            rotate.Rotate(matrix);
        }

        [TestMethod]
        public void TestSum()
        {
            TwoSum sum = new TwoSum();
            var resul = sum.GetIndicesForSumOptimized(new int[] { 2, 2, 2, 7 }, 9);
            CollectionAssert.AreEqual(new int[] { 1, 2 }, resul);
        }

        [TestMethod]

        public void TestMyCalendar()
        {
            var calendar = new MyCalendar();
            //calendar.Book(10, 20); // returns true
            //calendar.Book(15, 25); // returns false
            //calendar.Book(20, 30); // returns true
        }


        [TestMethod]

        public void TestBinarySearchCircular()
        {
            CircularArraySearch search = new CircularArraySearch();
            int[] input = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            search.Search(input, 0);
        }


        [TestMethod]
        public void TestCobinationSolution()
        {
            int[] input = new int[] { 2, 3, 6, 7 };

            var sol = new CobinationSolution();
            sol.CombinationSum(input, 7);
        }

        [TestMethod]
        public void TestSetZeroInMatrix()
        {
            SetZeoSolution sol = new SetZeoSolution();
            int[][] input = new int[1][]
            {
                new int[] { 0, 1},
            };

            int[][] output = new int[1][]
            {
                new int[] { 0, 1 },
            };
            sol.SetZeroesOptimal(input);

            CollectionAssert.Equals(input, output);
        }

        [TestMethod]
        public void TestMergeSolution()
        {
            int[] input1 = new int[] { 4, 5, 6, 0, 0, 0 };
            int[] input2 = new int[] { 1, 2, 3 };

            var output = new int[6] { 1, 2, 3, 4, 5, 6 };

            var sol = new MergeSolution();
            sol.Merge(input1, 3, input2, 3);

            CollectionAssert.Equals(output, input1);
        }


        [TestMethod]
        public void TestBinarSearchSolution()
        {
            int[] input = new int[] { 1, 2 };
            var sol = new BinarSearchSolution();
            var result = sol.FindMin(input);

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestBinarSearch2DSolution()
        {
            int[][] matrix = new int[][]
            {
                new int[4] {1,3,5,7},
                new int[4]{10, 11, 16, 20},
                new int[4]{23, 30, 34, 50},
            };

           // int[][] matrix = new int[][]
           //{
           //     new int[2] { 1,3}                
           //};


            var sol = new BinarSearchSolution();
            var result = sol.SearchMatrix(matrix,13);

            Assert.AreEqual(result, 1);
        }
    }
}

