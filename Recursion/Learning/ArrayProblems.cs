namespace Recursion.Learning
{
    internal class ArrayProblems
    {
        public List<int> Sort(List<int> array) // Hypothesis : will sort the array
        {
            if(array.Count == 1) // Base Condition : array with length = 1 is sorted
            {
                return array;
            }
            // Induction steps
            int temp = array[array.Count - 1]; // storing last index of the array
            array.RemoveAt(array.Count - 1); // reducing the size of the array
            array = Sort(array); // Hypothesis : will sorted the array with shorted i/p
            array = Insert(array, temp); // array is sorted, here our responsibility is the insert the last element at it's correct position in the sorted array
            return array;
        }

        /// <summary>
        /// Insert temp at the correct position, input array is sorted
        /// </summary>
        /// <param name="array"></param>
        /// <param name="temp"></param>
        /// <returns></returns>
        private List<int> Insert(List<int> array, int temp) // add temp value in sorted array
        {
           // Base condition 
           if(array.Count == 0 || array[array.Count - 1] <= temp)
           {
                array.Add(temp);
                return array;
           }
           // Induction steps
           int value = array[array.Count - 1];
           array.RemoveAt(array.Count - 1);
           array = Insert(array, temp);
           array.Add(value);
           return array; 
        }
    }
}
