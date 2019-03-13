 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class ImageRotate
    {
        public static int[,] RotateImageBy90(Int16[,] sourceMatrix)
        {
            int rowCount = sourceMatrix.GetLength(0);
            int columnCount = sourceMatrix.GetLength(0);


            int[,] destination = new int[columnCount, rowCount];

            for (int column = 0;column < columnCount; column++)
            {
                for (int row = 0; row < rowCount; row++)
                {
                    destination[row, column] = sourceMatrix[rowCount-1-column, row];                   
                }
                Console.WriteLine();
            }
            return destination;
        }
    }
}
