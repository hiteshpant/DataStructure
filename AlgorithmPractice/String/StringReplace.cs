using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.String
{
    public class StringReplace
    {
        public static StringBuilder ReplaceString(string input, string replcaeWith = "%20")
        {
            StringBuilder outputString = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                    outputString.Append(replcaeWith);
                else
                    outputString.Append(input[i]);

            }
            return outputString;
        }
    }
}
