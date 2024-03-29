namespace StringArray.Arrays
{
    internal class SetMatrixZeroes
    {
        /// <summary>
        /// https://leetcode.com/problems/set-matrix-zeroes/
        /// </summary>
        /// <param name="matrix"></param>
        public void SetZeroes(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;
            int[] rowArray = new int[row];
            int [] colArray = new int[col];

            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rowArray[i] = 1;
                        colArray[j] = 1;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                if (rowArray[i] == 1)
                {
                    for (int j = 0; j < col; j++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            for (int j = 0; j < col; j++)
            {
                if (colArray[j] == 1)
                {
                    for (int i = 0; i < row; i++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }

        /// <summary> 
        /// Solve with O(1) Space complexity
        /// </summary>
        /// <param name="matrix"></param>
        public void SetZeroes1(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;
            int rowZero = 1;

            //determine which rows/cols need to be zero
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        // if we are first row
                        if (i == 0)
                        {
                            rowZero = 0;
                        }
                        else
                        {
                            matrix[0][j] = 0;
                            matrix[i][0] = 0;
                        }
                    }
                }
            }

            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < col; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            if (matrix[0][0] == 0)
            {
                for (int i = 0; i < row; i++)
                {
                    matrix[i][0] = 0;
                }
            }

            if (rowZero == 0)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[0][j] = 0;
                }
            }
        }
    }
}
