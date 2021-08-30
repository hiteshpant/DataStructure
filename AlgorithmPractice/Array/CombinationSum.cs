using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{
    public class CobinationSolution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            if (candidates.Length == 0)
            {
                return result;
            }

            List<int> decisonTree = new List<int>();
            GetCombinationSumHelper(result, decisonTree, candidates, target, 0);
            return result;
        }

        void GetCombinationSumHelper(List<IList<int>> result, List<int> decisonTree, int[] candidates, int target, int index)
        {
            if (target == 0)
            {
                result.Add(new List<int>(decisonTree));
            }

            for (int i = 0; i < candidates.Length; i++)
            {
                if (candidates[i] > target)
                    break;
            }

            decisonTree.Add(candidates[index]);
            GetCombinationSumHelper(result, decisonTree, candidates, target - candidates[index], index);
            decisonTree.Remove(decisonTree.Count - 1);

        }
    }
}
