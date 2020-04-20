using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{
    public class TwoSum
    {
        public int[] GetIndicesForSum(int[] nums, int target)
        {
            int targetVal = target;
            int complementingValue;
            int[] indices = new int[] { -1, -1 };
            int i = 0, j = 1;
            while (j < nums.Length)
            {               
                complementingValue = target - nums[i];
                if (nums[j] == complementingValue)
                {
                    indices[1] = j;
                    indices[0] = i;
                    break;
                }
                else
                {
                    j++;
                    ////if (j == nums.Length - 1)
                    ////{
                    ////    i++;
                    ////    j = i + 1;
                    ////}
                    //else
                    //    j++;

                }

            }
            return indices;
        }
    }
}
