namespace Recursion.Learning
{
    internal class NumberExample
    {
        //public static void Main(string[] args)
        //{
        //    // Write a function that takes in a number and prints it.
        //    // print : 1,2,3,4,5
        //    Print(1);
        //}

        /// <summary>
        /// Recursive solution to print first 5 numbers
        /// </summary>
        /// <param name="n"></param>
        static void Print(int n)
        {
            if (n > 5)
                return;
            Console.WriteLine(n);
            // this is called tailed recursion
            Print(n + 1);
        }


        // Function based solution
        //static void Print1(int num)
        //{
        //    Console.WriteLine(num);
        //    Print2(2);
        //}

        //static void Print2(int num)
        //{
        //    Console.WriteLine(num);
        //    Print3(3);
        //}

        //static void Print3(int num)
        //{
        //    Console.WriteLine(num);
        //    Print4(4);
        //}
        //static void Print4(int num)
        //{
        //    Console.WriteLine(num);
        //    Print5(5);
        //}
        //static void Print5(int num)
        //{
        //    Console.WriteLine(num);
        //}


        // n-- vs --n
        // n-- : pass the value first than subtract it
        // --n : subtract first then pass the value
    }
}
