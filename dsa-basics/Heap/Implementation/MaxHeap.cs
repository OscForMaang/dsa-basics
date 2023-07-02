namespace Heap.Implementation
{
    internal class MaxHeap
    {
        /*
         * Heap Tree: 
         *      A Binary tree with below properties: 
         *        1. Structure Property :
         *              All the levels have maximum number of nodes except possibly the last level, In the last level, all the nodes are to the left
         *              Complete Binary tree: H = CeilOf(log(n+1))
         *        2. Heap order Property :
         *              Key in any node N is greater than or equal to the keys in the both children of N
         *              Root node is the height key
         * In heap tree, there is no order maintain between sibling nodes 
         * Max Heap and Min heap
         * 
         * Representation of Heap, Since heap is complete binary tree, we can use Array to implement data structure
         *  1. Root : Index of the array
         *  2. Left child of node N at index i : index 2i
         *  3. Right Child of node N at index i : index 2i + 1
         *  4. Parent of node at index i : index floor(i/2)
         *  
         *  
         *  Note: 
         *      1. if 2i > n : Left child doesn't exist
         *      2. if 2i + 1 > n: Right child doesn't exist
         *      
         *  Insertion in Heap tree: 
         *      Time complexity for insertion : Height of the tree
         *      
         */

        int[] heap;
        int size;
        public MaxHeap()
        {
            heap = new int[100];
            heap[0] = int.MaxValue;
            size = 0;
        }

        public MaxHeap(int size)
        {
           heap = new int[size];
           heap[0] = int.MaxValue;
           size = 0;
        }

        /// <summary>
        /// Insert an element in Max heap tree
        /// </summary>
        /// <param name="key"></param>
        public void Insert(int key)
        {
            size++;
            heap[size] = key;
            RestoreUp(size);
        }

        /*
         * Deletion in Heap
         * Heap of size n
         * Key in the root is stored in some variable
         * Key in last node is copied to the root node -> Key at index n is coped to index 1
         * Size of heap is decreased to n-1
         * restoreDown for key in root node
         */

        /// <summary>
        /// Delete root node from the heap tree
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public int DeleteRoot(int key)
        {
            if(size == 0) 
                throw new InvalidOperationException("Heap is empty");

            int maxValue = heap[1];

            heap[1] = heap[size];
            size--;
            RestoreDown(1);
            return maxValue;
        }

        /*
         * Building a heap from an array - Heapify
         *  1. Top Down Approach 
         *      Uses restore up Procedure
         *      Consider that the array represents a complete binary tree
         *      Call restoreUp for all elements from 1 to n index
         *  2. Bottom Up Approach
         *      Uses restoreDown procedure
         *      Consider that the array represents a complete binary tree
         *      Start from first non-leaf node
         *      Call restoreDown for each node of the tree till root node
         *      first non-leaf node -> index floor(n/2)
         */

        /// <summary>
        /// Heapify an array using top down approach
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="size"></param>

        public void BuildHeapTopDownApproach(int[] arr, int size)
        {
            for(int i = 2; i <= size; i++)
            {
                RestoreUp( arr, i);
            }
        }

        private void RestoreUp(int[] arr, int i)
        {

            int key = arr[i];
            int parentOfIndex = i / 2;

            while (arr[parentOfIndex] < key)
            {
                arr[i] = arr[parentOfIndex];
                i = parentOfIndex;
                parentOfIndex = i / 2;
            }
            arr[i] = key;
        }

        public void BuildHeapBottomUpApproach(int[] arr, int size)
        {
            for(int i = size / 2; i >= 1; i--)
            {
               RestoreDown(arr, i);
            }
        }

        private void RestoreDown(int[] arr, int i)
        {
            int key = arr[i];
            int leftChild = i * 2;
            int rightChild = leftChild + 1;

            while (rightChild <= size)
            {
                if (key >= arr[rightChild] && key >= arr[leftChild])
                {
                    arr[i] = i;
                    return;
                }
                else if (arr[leftChild] < arr[rightChild])
                {
                    arr[i] = arr[leftChild];
                    i = leftChild;
                }
                else
                {
                    arr[i++] = arr[rightChild];
                    i = rightChild;
                }
                leftChild = i * 2;
                rightChild = leftChild + 1;

            }

            // If the number of node is even
            if (leftChild == i && key < arr[i])
            {
                arr[i] = heap[leftChild];
                i = leftChild;
            }

            arr[i] = key;
        }

        /// <summary>
        /// Restore up fixes the heap order property after node insertion
        /// </summary>
        /// <param name="index"></param>
        private void RestoreUp(int index)
        {
            int key = heap[index];
            int parentOfIndex = index / 2;

            while (heap[parentOfIndex] < key)
            {
                heap[index] = heap[parentOfIndex];
                index = parentOfIndex;
                parentOfIndex = index / 2;
            }
            heap[index] = key;
        }


        /*
         * Key k : violates heap order property
         * RetoreDown for the key k
         * Compare k with it's left and right child
         *  CASE: 1 - both children are smaller than K - nothing to be done
         *  CASE: 2 - one children is greater than k - greater child moved up
         *  CASE: 3 - both children are greater than k - Larger of the two moved up
         *  Run time complexity : Height of the tree
         */
        /// <summary>
        /// Restore down, fixes the heap order property after node deletion
        /// </summary>
        /// <param name="index"></param>
        private void RestoreDown(int index)
        {
            int key = heap[index];
            int leftChild = index * 2;
            int rightChild = leftChild + 1;

            while (rightChild <= size)
            {
                // case 1: 
                if(key >= heap[rightChild] && key >= heap[leftChild])
                {
                    heap[index] = index;
                    return;
                }else if (heap[leftChild] < heap[rightChild])
                {
                    heap[index] = heap[leftChild];
                    index = leftChild;
                }
                else
                {
                    heap[index++] = heap[rightChild];
                    index = rightChild;
                }
                leftChild = index * 2;
                rightChild = leftChild + 1;

            }

            // If the number of node is even
            if(leftChild == index && key < heap[index])
            {
                heap[index] = heap[leftChild];
                index = leftChild;
            }

            heap[index] = key;
        }
    }
}
