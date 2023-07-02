namespace BitwiseOperator.Practice
{
    internal class OddEven
    {
        public bool IsEven(int num)
        {
            // Last bit from right (LSB: Least significant bit), determines if a number is odd or even
            // Except last bit from right, they will be even only 
            return (num & 1) == 0;
        }
    }
}
