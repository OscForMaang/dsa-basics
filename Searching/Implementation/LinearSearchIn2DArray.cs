namespace Searching.Implementation
{
    internal class LinearSearchIn2DArray
    {
        /// <summary>
        /// Search an element in 2D Array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] Search(int[][] arr, int target)
        {

            for(int row = 0; row < arr.Length; row++)
            {
                for (int col = 0; col < arr[row].Length; col++)
                {
                    if (arr[row][col] == target) 
                        return new int[] {row, col};

                }
            }
            return new int[] { };
        }



    }
}
