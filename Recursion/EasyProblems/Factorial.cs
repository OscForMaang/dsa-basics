namespace Recursion.EasyProblems
{
    internal class Factorial
    {
        /// <summary>
        /// Find the factorial of given number 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int GetFactorial(int num)
        {
            if(num <= 1) 
                return 1;

            return num * GetFactorial(num - 1);
        }
    }
}
