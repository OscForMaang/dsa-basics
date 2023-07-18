namespace Recursion.EasyProblems
{
    internal class SumOfDigits
    {
        public int GetSumOfDigits(int num)
        {
            if (num < 10)
                return num;
            return num % 10 + GetSumOfDigits(num / 10);
        }
    }
}
