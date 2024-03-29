namespace Searching.BinarySearchPractice
{
    internal class SearchInMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int top = 0;
            int bottom = matrix.Length-1;

            while(top <= bottom)
            {
                int row = top + (bottom - top) / 2;
                int val = matrix[row][0];
                if(target == val)
                    return true;
                else if(val > target)
                    bottom = row - 1;
                else
                    top = row + 1;
            }
             
            int row1 = (top + bottom) / 2;
            int start = 0;
            int end = matrix[0].Length - 1;
            while(start <= end)
            {
                int col = start + (end - start) / 2;
                int val = matrix[row1][col];
                if (val == target)
                    return true;
                else if (val > target)
                    end = col - 1;
                else
                    start = col + 1;
            }

            return false;
        }
    }
}
