using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{
    public class BinarSearchSolution
    {

        public int FindMin(int[] nums)
        {
            return DoMinBinarySearch(nums, 0, nums.Length - 1);
        }


        /// <summary>
        /// Handles equals case also for this problem
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private int DoMinBinarySearch(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] > nums[end])
                    start = mid + 1;
                else if (nums[mid] < nums[end])
                    end = mid;
                else
                    end--;
            }
            return nums[start];

        }

        public bool Search(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                    return true;
                if (nums[mid] > nums[end])
                    start = mid + 1;
                else
                    end = mid;
            }
            return false;
        }
       


        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return false;
            if (matrix.Length == 1 && matrix[0].Length == 1)
            {
                if (matrix[0][0] == target)
                    return true;
                else return false;
            }



            int columLength = matrix[0].Length - 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (target > matrix[i][columLength])
                    continue;
                else
                    return DoBinarySearch1(matrix[i], 0, columLength, target);
            }
            return false;

        }

        private bool DoBinarySearch1(int[] arr, int start, int end, int target)
        {
            while (end >= start)
            {
                int midpoint = (start + end) / 2;

                if (arr[midpoint] > target)
                {
                    end = midpoint - 1;
                }
                else if (arr[midpoint] < target)
                {
                    start = midpoint + 1;
                }
                else if (arr[midpoint] == target)
                {
                    return true;
                }

            }
            return false;

        }

    }
}
