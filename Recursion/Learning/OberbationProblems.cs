namespace Recursion.Learning
{
    internal class OberbationProblems
    {
        public int KthGrammar(int n, int k)
        {
            if (n == 1 && k == 1)
                return 0;

            int mid = (int)Math.Pow(2, n - 1) / 2;
            if(k <= mid)
                return KthGrammar(n - 1, k);
            else
            {
                int res = KthGrammar(n - 1, k - mid);
                return res == 0 ? 1 : 0;
            }
                
        }


        public void TOH(int  n, char source, char destination, char helper) // will move the plate from source to destination
        {
            if(n == 1)
            {
                Console.WriteLine($"Moving plate {n} : {source} - > {destination}");
                return;
            }
            TOH(n - 1, source, helper, destination);
            Console.WriteLine($"Moving plate {n} : {source} - > {destination}");
            TOH(n - 1, helper, destination, source);

        }
    }
}
