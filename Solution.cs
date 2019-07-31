using System;

namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int leftI = 0;
            int rightI = height.Length - 1;

            int maxSize = -1;

            while (rightI > leftI)
            {
                int left = height[leftI];
                int right = height[rightI];

                int size = Math.Min(left, right) * (rightI - leftI);
                maxSize = Math.Max(size, maxSize);

                if (left < right)
                    leftI++;
                else
                    rightI--;
            }

            return maxSize;
        }
    }
}
