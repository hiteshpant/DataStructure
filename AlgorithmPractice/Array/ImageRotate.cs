using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    public class ImageRotate
    {
        public void Rotate(int[][] matrix)
        {
        

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i; j < matrix[0].Length; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            int startIndex = 0, endIndex = matrix.Length - 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                while (endIndex > startIndex)
                {
                    var temp = matrix[i][startIndex];
                    matrix[i][startIndex] = matrix[i][endIndex];
                    matrix[i][endIndex] = temp;
                    endIndex--;
                    startIndex++;
                }
                startIndex = 0;
                endIndex = matrix.Length - 1;
            }

        }
    }
}
