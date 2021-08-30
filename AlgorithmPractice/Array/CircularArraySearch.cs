using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{
    public class CircularArraySearch
    {
        public int Search(int[] nums, int target)
        {
            if(nums.Length==0)
            {
                return -1;
            }
            int low = 0, high = nums.Length - 1;
            int mid = 0;
            while (high >= low)
            {
                mid = (low + high) / 2;
                //case 1
                if (nums[mid] == target)
                    return mid;
                //case 2 : right half is sorted
                if (nums[mid] <= nums[high])
                {
                    if (target > nums[mid] && target <= nums[high])
                        low = mid + 1;
                    else
                        high = mid - 1;
                }
                else
                {
                    if (target >= nums[low] && target < nums[mid])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
            }
            return -1;
        }

    }
}
