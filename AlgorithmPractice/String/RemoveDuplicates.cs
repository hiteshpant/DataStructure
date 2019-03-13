using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    public class RemoveDuplicates
    {
        public int RemoveDuplicateCharacter(ref StringBuilder input)
        {
            int index = 0;
            int i = 0, j = 0;
            for (i = 0; i < input.Length; i++)
            {
                for (j = 0; j < i; j++)

                {
                    if (input[i] == input[j])
                        break;
                }

                if (i == j)
                {
                    input[index++] = input[i];
                }
            }
            return index;
        }
    }
}
