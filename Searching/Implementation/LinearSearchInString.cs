namespace Searching.Implementation
{
    internal class LinearSearchInString
    {
        /// <summary>
        /// Search in the string: return true if the target character found
        /// </summary>
        /// <param name="str"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchChar(string str, char target)
        {
            if(str.Length == 0) 
                return false;

            foreach(char c in str)
            {
                // target found
                if (c == target)
                    return true;
            }

            // target char not founf
            return false;
        }
    }
}
