namespace Recursion.Learning
{
    internal class RecursionLearningBasic
    {
        //public static void Main(string[] args)
        //{
        //    Message();
        //}

        static void Message()
        {
            Console.WriteLine( "Hello World");
            Message1();
        }
        static void Message1()
        {
            Console.WriteLine("Hello World");
            Message2();
        }

        static void Message2()
        {
            Console.WriteLine("Hello World");
            Message3();
        }

        static void Message3()
        {
            Console.WriteLine("Hello World");
            Message4();
        }
        static void Message4()
        {
            Console.WriteLine("Hello World");
            Message5();
        }

        static void Message5()
        {
            Console.WriteLine("Hello World");
        }
    }
}
