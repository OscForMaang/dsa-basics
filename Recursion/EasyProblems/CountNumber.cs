namespace Recursion.EasyProblems
{
    internal class CountNumber
    {
        public int GetNumberOfZero(int num)
        {
            if(num == 0) return 0;
            return num % 10 == 0 ? 1 + GetNumberOfZero(num / 10)
                : GetNumberOfZero(num / 10);
        }
    }
}
