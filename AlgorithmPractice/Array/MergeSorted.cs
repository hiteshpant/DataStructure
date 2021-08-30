using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{
    public class MergeSolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
            {
                return;
            }
            int p1 = 0;
            int p2 = 0;
            int[] numsCopy = new int[m];
            System.Array.Copy(nums1, 0, numsCopy, 0, m);
            int destinationIndex = 0;
            while (p1 < m && p2 < n)
            {
                if (numsCopy[p1] < nums2[p2])
                {
                    nums1[destinationIndex] = numsCopy[p1];
                    p1++;
                }
                else
                {
                    nums1[destinationIndex] = nums2[p2];
                    p2++;
                }
                destinationIndex++;
            }

            if (p1 < m)
            {
                System.Array.Copy(numsCopy, p1, nums1, destinationIndex, nums1.Length - destinationIndex);
            }
            if (p2 < n)
            {
                System.Array.Copy(nums2, p2, nums1, destinationIndex, nums1.Length - destinationIndex);

            }

        }


        public void MergeOptimized(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            int p = m + n - 1;

            while (p1 > 0 && p2 < 0)
            {
                nums1[p--] = nums1[p1] > nums2[p2] ? nums1[p1--] : nums2[p2--];
            }

            System.Array.Copy(nums2, 0, nums1, 0, p + 1);

        }
    }
}
