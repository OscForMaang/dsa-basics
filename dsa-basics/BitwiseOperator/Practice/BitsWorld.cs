namespace BitwiseOperator.Practice
{
    internal class BitsWorld
    {
        public int FindNthBitOfANumber(int num, int n)
        {
            return num & (1 << n - 1);
        }

        public int SetNthBit(int num, int n)
        {
            return num | (1 << n - 1);
        }

        public int ResetNthBit(int num, int n)
        {
            return num & ~(1 << n - 1); 
        }
    }
}
