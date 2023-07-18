namespace Recursion.EasyProblems
{
    internal class PrintNumbers
    {
        /// <summary>
        /// Print number from N to 1;
        /// </summary>
        /// <param name="num"></param>
        public void PrintInReverse(int num)
        {
            if (num == 0)
                return;
            Console.WriteLine(num + " ");
            PrintInReverse(num - 1);
        }

        /// <summary>
        /// Print the number from 1 to N
        /// </summary>
        /// <param name="num"></param>
        public void Print(int num)
        {
            if(num == 0)
                return;

            Print(num - 1);
            Console.WriteLine(num);
        }
    }
}
