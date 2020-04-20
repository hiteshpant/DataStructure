using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    public class Anagram
    {
        public static bool CheckAnagram(string input1, string input2)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(input1) && !string.IsNullOrEmpty(input2) &&
                input2.Length == input1.Length)
            {
                int[] charCheck = new int[256];
                for (int i = 0; i < input1.Length; i++)
                {
                    charCheck[input1[i]]++;
                    charCheck[input2[i]]--;
                }              
            }
            else
                result = false;
            return result;
        }
      
    }
}
