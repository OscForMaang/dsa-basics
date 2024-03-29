namespace StringArray.Arrays
{
    internal class CanJumpProblem
    {
        /// <summary>
        /// https://leetcode.com/problems/jump-game/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool CanJump(int[] nums)
        {
            for (int position = 0; position < nums.Length-1; position++)
            {
                // we need to evaluate this position  
                if (nums[position] == 0)
                {
                    for (int i = 0; i <= position; i++)
                    {
                        // we are skiping zero as it is alerady passed
                        int jumpIndex = nums[i] + i;
                        if (nums[i] != 0 && jumpIndex > position) // Index with zero has been jumped
                        {
                            break; // no need to validate it further
                        }
                        // didn't manage to jump zero
                        if(i == position)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public bool CanJumpGreedy(int[] nums)
        {
            int goal = nums.Length - 1;
            for(int i = nums.Length-1; i >= 0; i++)
            {
                if(i + nums[i] >= goal)
                {
                    goal = i;
                }
            }
            if(goal == 0)
                return true;
            return false;
        }

        /// <summary>
        /// https://leetcode.com/problems/jump-game-ii/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int CanJump2(int[] nums)
        {
            int jump = 0;
            int left = 0, right = 0;
            while(right < nums.Length-1)
            {
                int farthest = 0;
                for (int i = left; i < right; i++)
                {
                    farthest = Math.Max(i + nums[i], farthest);
                }
                left = right + 1;
                right = farthest;
                jump++;
            }

            return jump;
        }
    }
}
