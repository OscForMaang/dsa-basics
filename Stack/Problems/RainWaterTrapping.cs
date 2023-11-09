namespace Stack.Problems
{
    internal class RainWaterTrapping
    {
        public int Trap(int[] height)
        {
            int water = 0;
            int len = height.Length;
            int[] maxL = new int[len];

            maxL[0] = height[0];

            for (int i = 1; i < len; i++)
            {
                maxL[i] = Math.Max(maxL[i - 1], height[i]);
            }

            int maxR = height[len - 1];
            water = Math.Min(maxL[len - 1], maxR) - height[len-1]; // starting from back

            for (int i = len-2;  i >= 0; i-- )
            {
                maxR = Math.Max(maxR, height[i]);

                water += Math.Min(maxL[i], maxR) - height[i];
            }

            return water;
        }
    }
}
