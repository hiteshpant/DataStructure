
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{
    public class TwoSum
    {        

        public int[] GetIndicesForSumOptimized(int[] nums, int target)
        {
            Dictionary<int,int> compliments = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var key = target - nums[i];
                if (compliments.ContainsKey(key))
                {
                    return new int[] { compliments[key],i };
                }
                compliments[nums[i]] = i;
            }

            return new int[] { -1, -1 };
            
        }
    }
}

