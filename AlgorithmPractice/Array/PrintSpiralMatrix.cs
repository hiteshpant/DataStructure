using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{
    public class SolutionSpiral
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> output = new List<int>();
            if (matrix == null || matrix.Length == 0)
                return output;

            int rowLastIndex = matrix.Length - 1;
            int columnLastIndex = matrix[0].Length - 1;

            for (int i = 0; i <= rowLastIndex; i++)
            {
                output.Add(matrix[0][i]);
            }

            for (int i = 1; i <= columnLastIndex; i++)
            {
                output.Add(matrix[i][columnLastIndex]);
            }

            for (int i = columnLastIndex - 1; i >= 0; i--)
            {
                output.Add(matrix[rowLastIndex][i]);
            }

            for (int i = rowLastIndex-1; i >0; i--)
            {
                output.Add(matrix[rowLastIndex][0]);
            }


            for (int i = 1; i < columnLastIndex; i++)
            {
                output.Add(matrix[1][i]);
            }
            return output;
        }
    }
}
