using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.String
{
    public class LongestCommonSubsequence
    {

        public string PrintLongestCommonSubsequence(string input1, string input2)
        {
            var lcsTable = GetLongestSubsequenceLength(input1, input2);
            int lcsLength = lcsTable[input1.Length, input2.Length];
            StringBuilder sb = new StringBuilder(lcsLength);
           
            int row = input1.Length;
            int column = input2.Length;

            while (row > 0 && column > 0)
            {
                if (input1[row-1] == input2[column-1])
                {
                    sb.Append(input2[column-1]);
                    row--;
                    column--;
                }
                else
                {
                    if (lcsTable[row, column - 1] >= lcsTable[row - 1, column])
                        column--;
                    else
                        row--;
                }

            }

            return sb.ToString().Reverse().ToString();

        }


        /// <summary>
        /// This is DP bottom up approach where table gets filled in top down fashion
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public int[,] GetLongestSubsequenceLength(string input1, string input2)
        {
            int[,] lcs = new int[input1.Length + 1, input2.Length + 1];
            for (int i = 0; i <= input1.Length; i++)
            {
                for (int j = 0; j <= input2.Length; j++)
                {
                    if (i == 0 || j == 0)
                        lcs[i, j] = 0;

                    else if (input1[i - 1] == input2[j - 1])
                    {
                        lcs[i, j] = lcs[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);
                    }
                }

            }
            return lcs;

        }

        /// <summary>
        /// Get The Longest Subsequence based on rcursive calls
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public int GetLCS(string input1, string input2, int i, int j)
        {
            if (i >= input1.Length || j >= input2.Length)
            {
                return 0;
            }

            else if (input1[i] == input2[j])
            {
                return 1 + GetLCS(input1, input2, i + 1, j + 1);
            }
            else
                return Math.Max(GetLCS(input1, input2, i + 1, j), GetLCS(input1, input2, i, j + 1));
        }

    }
}
