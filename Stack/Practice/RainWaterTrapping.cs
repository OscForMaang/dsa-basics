namespace Stack.Practice
{
    internal class RainWaterTrapping
    {
        // Later: Reviste
        public int Trap(int[] height)
        {
            int[] maxL = new int[height.Length];
            int[] maxR = new int[height.Length];
            int end = height.Length -1;
            maxL[0] = height[0];
            maxR[end] = height[end];
            end--;
            for (int start = 1; start < height.Length; start++, end--)
            {
                maxL[start] = Math.Max(maxL[start-1], height[start]);
                maxR[end] = Math.Max(maxR[end+1], height[end]);
            }
            int area = 0;
            for (int i = 0; i < height.Length; i++)
            {
                area += Math.Min(maxL[i], maxR[i]) - height[i];
            }
            return area;
        }  
    }
}
