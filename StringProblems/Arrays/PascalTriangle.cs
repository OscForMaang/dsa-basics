namespace StringArray.Arrays
{
    internal class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>() { 1 });
            if(numRows == 1)
                return result;

            result.Add(new List<int>() { 1,1 });
            if(numRows == 2)
                return result;

            for(int i = 1; i < numRows-1; i++)
            {
                List<int> res = new List<int>() { 1 };
                for(int j = 0; j < result[i].Count-1; j++)
                {
                    res.Add(result[i][j] + result[i][j+1]);
                }
                res.Add(1);
                result.Add(res);
            }

            return result;  
         }

        public IList<int> GetRow(int rowIndex)
        {
            int[] res = new int[rowIndex + 1];
            if (rowIndex == 1)
                return new List<int>() { 1 };
             if (rowIndex == 2)
                return new List<int>() { 1,1 };

            res[0] = 1;
            res[1] = 1;
            int currIndex = 1;
            for (int i = 0; i < rowIndex; i++)
            {
                int prev = 1;
                for (int j = 1; j <= currIndex; j++)
                {
                    res[j] = prev + res[j];
                    prev = res[j];
                }
                res[currIndex] = 1;
                currIndex++;
            }
            return res.ToList();
        }
    }
}
