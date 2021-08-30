using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.BackTracking
{
    public class PhoneNumberSol
    {
        List<string> output = new List<string>();
        Dictionary<int, string> _PhoneMapper = new Dictionary<int, string>();
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return Enumerable.Empty<string>().ToList();
            PopulatePhoneMapper();
            GetAllCombination(string.Empty,digits);
            return output;
        }

        private void PopulatePhoneMapper()
        {
            _PhoneMapper[2] = "abc";
            _PhoneMapper[3] = "def";
            _PhoneMapper[4] = "ghi";
            _PhoneMapper[5] = "jkl";
            _PhoneMapper[6] = "mno";
            _PhoneMapper[7] = "pqrs";
            _PhoneMapper[8] = "tuv";
            _PhoneMapper[9] = "wxyz";

        }

        private void GetAllCombination(string combination, string digits)
        {

            if (digits.Length == 0)
                output.Add(combination);
            else
            {
                var number = int.Parse(digits.Substring(0, 1));
                var mappingAlphabets = _PhoneMapper[number];
                for (int i = 0; i < mappingAlphabets.Length; i++)
                {
                    string singleCharValue = mappingAlphabets.Substring(i, i + 1);
                    GetAllCombination(combination + singleCharValue, digits.Substring(1));

                }
            }       
        }
    }
}
