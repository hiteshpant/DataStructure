﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{

    //    Given a m x n matrix, if an element is 0, set its entire row and column to 0. Do it in-place.

    //Example 1:

    //Input: 
    //[
    //  [1,1,1],
    //  [1,0,1],
    //  [1,1,1]
    //]
    //Output: 
    //[
    //  [1,0,1],
    //  [0,0,0],
    //  [1,0,1]
    //]
    //Example 2:

    //Input: 
    //[
    //  [0,1,2,0],
    //  [3,4,5,2],
    //  [1,3,1,5]
    //]
    //Output: 
    //[
    //  [0,0,0,0],
    //  [0,4,5,0],
    //  [0,3,1,0]
    //]
    //Follow up:

    //A straight forward solution using O(mn) space is probably a bad idea.
    //A simple improvement uses O(m + n) space, but still not the best solution.
    //Could you devise a constant space solution?
    public class SetZeoSolution
    {

        public void SetZeroes(int[][] matrix)
        {
            HashSet<int> row = new HashSet<int>();
            HashSet<int> column = new HashSet<int>();


            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[i].Length; j++)
                {
                  if(matrix[i][j]==0)
                    {
                        row.Add(i);
                        column.Add(j);
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[i].Length; j++)
                {
                   if(row.Contains(i) || column.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }


        public void SetZeroesOptimal(int[][] matrix)
        {

            bool isFirstRowZero=false;
            bool isFirstColumZero=false;

            if (matrix == null || matrix[0] == null)
                return;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                if (matrix[0][i] == 0)
                {
                    isFirstRowZero = true;
                    break;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    isFirstColumZero = true;
                    break;
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[i].Length; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            if(isFirstColumZero)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][0] = 0;
                }
            }

            if (isFirstRowZero)
            {
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    matrix[0][i] = 0;
                }
            }
        }
    }
}
