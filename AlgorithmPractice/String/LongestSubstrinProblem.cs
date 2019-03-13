using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.String
{
    public class LongestSubstrinProblem
    {
        HashSet<int> set = new HashSet<int>();
        

        public int GetLongestSubstringlength(StringBuilder s)
        {
            int maxCount = 0;
            int lastMaxCount = 0;
            int startindex=0;
            for (int i = 0; i < s.Length; )
            {
                if (set.Contains(s[i]))
                {
                    if (lastMaxCount < maxCount)
                        lastMaxCount = maxCount;
                    maxCount = 0;
                    set.Clear();
                    startindex++;
                    i = startindex;
                }
                else
                {
                    set.Add(s[i]);
                    maxCount++;
                    i++;
                }
            }
            return lastMaxCount > maxCount ? lastMaxCount : maxCount;
        }

        public int OptimizedGetLongestSubstringlength(StringBuilder s)
        {
            int maxCount = 0;
            int leftPointer = 0;
            for (int rightPointer = 0; rightPointer < s.Length;)
            {
                if (set.Add(s[rightPointer]))
                {                
                    rightPointer++;
                    maxCount = Math.Max(maxCount, rightPointer - leftPointer);
                }
                else //Shift the window
                {
                    set.Remove(s[leftPointer]);
                    leftPointer++;
                }
            }
            return maxCount;
        }

    }
}
