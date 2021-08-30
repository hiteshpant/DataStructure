using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.String
{
    public class LongestSubstrinProblem
    {
        public int OptimizedGetLongestSubstringlength1(string s)
        {
            var currentIndex = 0;
            var rightIndex = 0;
            int currentlength = 1;
            HashSet<char> map = new HashSet<char>();
            while (rightIndex < s.Length)
            {
                if (map.Add(s[rightIndex]))
                {
                    rightIndex++;
                    currentlength= Math.Max(currentlength, rightIndex-currentIndex);
                }
                else
                {
                    map.Remove(s[currentIndex]);
                    currentIndex++;
                }
            }

            return currentlength;
        }
    }
}
