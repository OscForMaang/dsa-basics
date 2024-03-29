namespace Mathematics
{
    internal class LuckyNumber
    {
        public bool isLucky(int n)
        {
           return IsLucky(n, 2);    
        }
        
        private bool IsLucky(int n, int counter)
        {
            if(counter > n)
                return true;
            if (n % counter == 0)
                return false;
            return IsLucky(n - n % counter, counter+1);
        }

        private bool IsLuckyNumber(int n)
        {
            int counter = 2;
            while(n >= counter)
            {
                if(n % counter == 0)
                    return false ;
                n = n - (n / counter);
                counter++;
            }

            return true;
        }
    }
}
