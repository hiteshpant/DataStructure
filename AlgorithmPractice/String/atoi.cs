using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.String
{
    //Implement atoi which converts a string to an integer.

    //The function first discards as many whitespace characters as necessary until the first non-whitespace character is found.Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.

    //The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.

    //If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.

    //If no valid conversion could be performed, a zero value is returned.

    //Note:

    //Only the space character ' ' is considered as whitespace character.
    //Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. If the numerical value is out of the range of representable values, INT_MAX (231 − 1) or INT_MIN(−231) is returned.

    public class AtoiSolution
    {
        public int MyAtoi(string str)
        {
            double result = 0;
            if (string.IsNullOrEmpty(str.Trim()))
            {
                return 0;
            }
            var inputItems = str.Trim().Split(' ');
            try
            {
                var firstCharacter = inputItems[0][0];
                var firstString = inputItems[0];
                bool isNumeric = false;
                if (ValidateInputForConversion(firstCharacter))
                {
                    if (!firstString.Contains('e'))
                    {
                        isNumeric = Double.TryParse(firstString, out result);
                    }
                    else
                    {
                        firstString = firstString.Substring(0, firstString.IndexOf('e'));
                        isNumeric = true;
                    }
                    if (isNumeric)
                    {
                        return GetConvertedNumericValue(firstString);
                    }
                    else
                    {
                        result = ConvetAlphaNumericStringToNumeric(firstString);
                    }
                }
                else
                {
                    result = 0;
                }
            }
            catch (System.FormatException e)
            {

            }
            return (int)result;
        }

        private int GetConvertedNumericValue(string input)
        {
            var result = Double.Parse(input);
            validateResultForMaxMIn(ref result);
            return (int)result;
        }
        private double ConvetAlphaNumericStringToNumeric(string firstString)
        {
            StringBuilder sb = new StringBuilder();
            double result = 0;
            for (int i = 0; i < firstString.Length; i++)
            {
                bool isValidNumber = i > 0 ? 48 <= firstString[i] && firstString[i] <= 57 :
                    ValidateInputForConversion(firstString[i]);

                if (isValidNumber)
                {
                    sb.Append(firstString[i]);
                }
                else
                {
                    break;
                }
            }
            if (sb.Length > 1)
            {
                result = Double.Parse(sb.ToString());
                validateResultForMaxMIn(ref result);
            }
            else if (sb[0] == '-')
            {
                result = 0;
            }
            else
            {
                result = Double.Parse(sb.ToString());
            }

            return result;
        }
        private static bool ValidateInputForConversion(char firstCharacter)
        {
            return firstCharacter == '-' || firstCharacter == '+' ||
                (48 <= firstCharacter && firstCharacter <= 57);
        }
        private void validateResultForMaxMIn(ref double result)
        {
            if (result > int.MaxValue)
            {
                result = Int32.MaxValue;
            }
            else if (result < Int32.MinValue)
            {
                result = Int32.MinValue;
            }
        }
    }
}
