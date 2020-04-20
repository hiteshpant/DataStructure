using System.Text;

namespace AlgorithmPractice
{
    internal class UniqueStringChecker
    {
        /// <summary>
        /// Checks for Uniques string using bitwise
        /// We keep checking wether bit is set or not
        /// if its already set it means input strig contain duplicate
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool CheckIfStringIsUnique(StringBuilder input)
        {
            bool result = false;

            int checker = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int bitIndex = 1 << 'a' - input[i];

                if ((checker & bitIndex) > 0)
                {
                    result = false;
                    break;
                }

                checker |= bitIndex;
                result = true;
            }
            return result;
        }

        public bool CheckIfStringIsUniqueUsingHash(StringBuilder input)
        {
            bool[] allCharSet = new bool[256];
            int charIndex = 0;
            bool result = true;
            for (int i = 0; i < input.Length; i++)
            {
                charIndex = 65 - input[i];
                if (allCharSet[charIndex] == false)
                    allCharSet[charIndex] = true;
                else
                {
                    result = false;
                    break;
                }
            }
            return result;

        }
    }
}