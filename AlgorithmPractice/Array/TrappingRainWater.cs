using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.


//The above elevation map is represented by array[0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]. In this case, 6 units of rain water (blue section) are being trapped. Thanks Marcos for contributing this image!


//Example:

//Input: [0,1,0,2,1,0,1,3,2,1,2,1]
//Output: 6
namespace AlgorithmPractice.Array
{
    public class TrappingRainWater
    {
        public int TrapBrutForce(int[] height)
        {
            int leftMax = 0, rightMax = 0;
            int result = 0;
            for (int i = 0; i < height.Length; i++)
            {
                leftMax = height[i];
                rightMax = height[i];
                for (int j = 0; j < i; j++)
                {
                    leftMax = Math.Max(leftMax, height[j]);
                }
                for (int k = i + 1; k < height.Length; k++)
                {
                    rightMax = Math.Max(rightMax, height[k]);
                }
                result += Math.Min(rightMax, leftMax) - height[i];
            }
            return result;
        }

        /// <summary>
        /// O(n) Space complexity
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int TrapOptimized(int[] height)
        {
            if (height.Length < 3)
                return 0;
            int leftMax = 0, rightMax = 0, result = 0;
            int left = 0, right = height.Length - 1;
            while (left < right)
            {
                if (height[right] > height[left])
                {

                    if (leftMax <= height[left])
                    {
                        leftMax = height[left];
                    }
                    else
                    {
                        result += (leftMax - height[left]);
                    }

                    ++left;
                }
                else
                {
                    if (rightMax <= height[right])
                    {
                        rightMax = height[right];
                    }
                    else
                    {
                        result += (rightMax - height[right]);
                    }
                    --right;
                }
            }
            return result;
        }        
    }
}

