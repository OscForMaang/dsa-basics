namespace Recursion.StackImportantQuestions
{
    internal class PrintNBitBinaryNumbers
    {
        public List<string> NBitBinary(int N)
        {
            List<string> list = new List<string>();
            // code here
            void Solve(int ones, int zeros, string result)
            {
                if(zeros + ones == N)
                {
                    list.Add(result);
                    return;
                }
                if(ones > zeros)
                    Solve(ones, zeros+1, $"{result}{0}");

                Solve(ones+1, zeros, $"{result}{1}");
            }
            Solve(1, 0, "1");

            return list;
        }
    }
}
