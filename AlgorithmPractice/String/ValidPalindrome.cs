using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.String
{
    public class PalindromSol
    {
        public bool ValidPalindrome(string s)
        {
            //int[] ocurrenceCount = new int[26];
            //int charIndex = 0;
            //foreach (var character in s)
            //{
            //    charIndex = 97 - character;
            //    ocurrenceCount[charIndex]++;
            //}
            int endIndex = s.Count() - 1;
            int startIndex = 0;
            string newString1 = string.Empty, newString2 = string.Empty;

            while (endIndex >= startIndex)
            {
                if (s[startIndex] == s[endIndex])
                {
                    startIndex++;
                    endIndex--;
                }
                else
                {
                    newString1 = s.Remove(startIndex, 1);
                    newString2 = s.Remove(endIndex, 1);
                    break;
                }
            }

            if (!string.IsNullOrEmpty(newString1) || !string.IsNullOrEmpty(newString2))
            {
                if (CheckPalindrome(newString1) || CheckPalindrome(newString2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return true;

        }

        private bool CheckPalindrome(string s)
        {
            int endIndex = s.Count() - 1;
            int startIndex = 0;
            bool result = true;
            while (endIndex >= startIndex)
            {
                if (s[startIndex] == s[endIndex])
                {
                    startIndex++;
                    endIndex--;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public bool validPalindrome(string s)
        {
            int l = -1, r = s.Length;
            while (++l < --r)
                if (s[l] != s[r]) return isPalindromic(s, l, r + 1) || isPalindromic(s, l - 1, r);
            return true;
        }

        public bool isPalindromic(string s, int l, int r)
        {
            while (++l < --r)
                if (s[l] != s[r])
                {
                    return false;
                }
            return true;
        }
    }
}
