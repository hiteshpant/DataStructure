using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            int islandCount = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        islandCount += CheckForIsland(i, j, grid);
                    }
                }

            }
            return islandCount;

        }

        private int CheckForIsland(int row, int column, char[][] grid)
        {
            var topRow = row-1;
            var bottomRow = row + 1;
            var leftColum = column - 1;
            var rightColumn = column + 1;
            var topValue = CheckForCorner(topRow, column, grid.Length) > 0 ? grid[topRow][column]-48 : 0;
            var bottomValue = CheckForCorner(bottomRow, column, grid.Length) > 0 ? grid[bottomRow][column]-48 : 0;
            var leftvalue = CheckForCorner(row, leftColum, grid.Length) > 0 ? grid[row][leftColum]-48 : 0;
            var rightValue = CheckForCorner(row, rightColumn, grid.Length) > 0 ? grid[row][rightColumn]-48 : 0;

            if (topValue + bottomValue + leftvalue + rightValue == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private int CheckForCorner(int row, int column, int length)
        {
            if (row < 0 || column >= length || column<0 || row>=length)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
