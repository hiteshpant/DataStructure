using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.String
{
    public class LisSolution
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums == null)
                return -1;
            if (nums.Length == 1)
                return 1;
            List<List<int>> output = new List<List<int>>(); ;
            for (int i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                var items = new List<int>();
                items.Add(current);
                for (int j = i; j < nums.Length; j++)
                {
                    if (current < nums[j])
                    {

                        items.Add(nums[j]);
                        current = nums[j];
                    }
                }
                output.Add(items);
            }

            return output.Max(x => x.Count);
        }
    }
}
