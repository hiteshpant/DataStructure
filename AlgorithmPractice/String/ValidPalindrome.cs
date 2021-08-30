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

    //    Given a string, determine if it is a palindrome, 
    //considering only alphanumeric characters and ignoring cases.

    //Note: For the purpose of this problem, we define empty string as valid palindrome.

    //Example 1:

    //Input: "A man, a plan, a canal: Panama"
    //Output: true
    //Example 2:

    //Input: "race a car"
    //Output: false
    public class PalindromSol2
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLowerInvariant();
            StringBuilder sb = new StringBuilder();
            bool result = true;
            if (string.Empty == s)
            {
                return result;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 'A' && s[i] <= 'z') || s[i] >= 48 && s[i] <= 57)
                {
                    sb.Append(s[i]);
                }
            }
            if (sb.ToString().Equals(sb.ToString().Reverse()))
            {
                result = false;
            }
            return result;
        }

        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s.ToString()))
            {
                return string.Empty;
            }

            int startIndex = 0;
            while (startIndex < s.Length)
            {
                if (s[startIndex] != ' ')
                {
                    break;
                }
                startIndex++;
            }

            Stack<StringBuilder> words = new Stack<StringBuilder>();
            StringBuilder word = new StringBuilder();
            for (int i = startIndex; i < s.Length; i++)
            {
                if (s[i] != ' ')
                    word.Append(s[i]);
                else
                {
                    if (!string.IsNullOrEmpty(word.ToString()))
                    {
                        words.Push(word);
                    }
                    word = new StringBuilder();
                }
            }
            if (!string.IsNullOrEmpty(word.ToString()))
                words.Push(word);
            StringBuilder output = new StringBuilder();
            while (words.Count > 0)
            {
                var currentWord = words.Pop();
                for (int j = 0; j < currentWord.Length; j++)
                {
                    output.Append(currentWord[j]);
                }
                if (words.Count != 0)
                    output.Append(" ");
            }
            return output.ToString();
        }
    }

    public class LongestPalindromeSol
    {
        public int LongestPalindrome(string s)
        {
            int[] countInput = new int[128];
            int length = 0;
            bool hasOddCount = false;
            foreach (var character in s)
            {
                countInput[character]++;
                if (countInput[character] == 2)
                {
                    length++;
                    countInput[character] = 0;
                }
            }

            for (int i = 0; i < countInput.Length; i++)
            {
                if (countInput[i] % 2 == 1)
                {
                    hasOddCount = true;
                }

            }
            return hasOddCount == true ? length * 2 + 1 : length * 2;
        }
    }
}
