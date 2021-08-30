using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.String
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            var inputItems = s.Trim().Split(' ');

            StringBuilder sb = new StringBuilder();
            for (int i = inputItems.Length - 1; i >= 0; i++)
            {
                if (!string.IsNullOrWhiteSpace(inputItems[i]))
                {
                    sb.Append(inputItems[i] + " ");
                }
            }
            return sb.ToString().Trim();
        }

        public void ReverseWords(char[] s)
        {
            if (s == null || s.Length == 0)
                return;
            int startIndex = 0, endIndex = s.Length - 1;
            SwapCharacter(startIndex, endIndex, s);
            int wordEndIndex = 0;
            for (int i = 0; i < s.Length;)
            {
                while (wordEndIndex <= s.Length)
                {
                    if (wordEndIndex == s.Length ||s[wordEndIndex] == ' ')
                    {
                        SwapCharacter(i, wordEndIndex - 1, s);
                        wordEndIndex++;
                        break;
                    }
                    wordEndIndex++;

                }            
                i = wordEndIndex;
            }
        }

        public void SwapUsingXor(char[] input)
        {
            int startIndex = 0;
            int endIndex = input.Length - 1;
            while(endIndex>startIndex)
            {
                input[startIndex] ^= input[endIndex];
                input[endIndex] ^= input[startIndex];
                input[startIndex] ^= input[endIndex];
            }
        }

        void SwapCharacter(int startIndex, int endIndex, char[] s)
        {
            while (endIndex > startIndex)
            {
                char temp = s[startIndex];
                s[startIndex] = s[endIndex];
                s[endIndex] = temp;
                endIndex--;
                startIndex++;
            }
        }
    }

}
