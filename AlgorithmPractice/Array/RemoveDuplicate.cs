using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{
    public class RemoveDuplicate
    {

        public int GetUniqueArrayLength(int[] input)
        {
            int uniqueArrayIndex = 0;
            for (int currentPointer = 0; currentPointer < input.Length - 1; currentPointer++)
            {
                if (input[currentPointer] == input[currentPointer + 1])
                    continue;
                else
                    input[++uniqueArrayIndex] = input[currentPointer + 1];
            }
            return input.Length > 0 ? uniqueArrayIndex + 1 : 0;
        }
    }
}
