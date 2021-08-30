using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.String
{
    public class LongestPalindromeSubstring
    {
        public string LongestPalindrome(string s)
        {
            
            int?[,] arr = new int?[s.Length, s.Length];
            GetLongestPalindrome(s, 0, s.Length - 1, arr);
            return string.Empty;
        }

        //DP Approach
        private int GetLongestPalindrome(string s, int startIndex, int endIndex, int?[,] arr)
        {
            if (startIndex > endIndex)
            {
                return 0;
            }
            if (startIndex == endIndex)
            {
                return 1;
            }

            if (arr[startIndex, endIndex] == null)
            {
                if (s[startIndex] == s[endIndex])
                {

                    int lpRemainingString = endIndex - startIndex - 1;
                    if (lpRemainingString == GetLongestPalindrome(s, startIndex + 1, endIndex - 1, arr))
                    {

                        arr[startIndex, endIndex] = 2 + lpRemainingString;
                        Console.WriteLine(s.Substring(startIndex + 2, endIndex));
                    }

                }
                else
                {
                    arr[startIndex, endIndex] = Math.Max(GetLongestPalindrome(s, startIndex, endIndex - 1, arr), GetLongestPalindrome(s, startIndex + 1, endIndex, arr));
                }
            }

            return arr[startIndex, endIndex].Value;
        }


        /// <summary>
        /// Expand from centre approach
        /// </summary>
        int maxLPlength = 0, lpStarttIndex = 0;
        public string longestPalindrome(string s)
        {
            if (s == null || s.Length < 1)
                return "";
          
            for (int i = 0; i < s.Length; i++)
            {
               expandAroundCenter(s, i, i);
               expandAroundCenter(s, i, i + 1);             
                
            }
            return s.Substring(lpStarttIndex, maxLPlength);
        }

        private void expandAroundCenter(string s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            var lpLength = R - L - 1;
            if (lpLength> maxLPlength)
            {
                lpStarttIndex = L + 1;
                maxLPlength = lpLength;
            }           
        }

       
    }
}
