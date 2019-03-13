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
                input2.Length==input1.Length)
            {

                int sum1 = input1.ToString().Aggregate((arg1, arg2) => Convert.ToChar(arg1 + arg2));
                int sum2 = input2.ToString().Aggregate((arg1, arg2) => Convert.ToChar(arg1 + arg2));

                if (sum1 == sum2)
                    result = true;
            }
            else
                result = false;
            return result;
        }

        private static char SunChar(char arg1, char arg2)
        {
            return Convert.ToChar((int)arg1 + (int)arg2);
        }
    }
}
