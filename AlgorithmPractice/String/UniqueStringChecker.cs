using System.Text;

namespace AlgorithmPractice
{
    internal class UniqueStringChecker
    {
        public bool CheckIfStringIsUnique(StringBuilder input)
        {
            bool result = false;

            int checker = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int charValue = input[i];

                if ((checker & (1 << charValue)) > 0)
                {
                    result = false;
                    break;
                }

                checker |= 1 << charValue;
                result = true;
            }

            return result;
        }
    }
}