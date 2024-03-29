namespace Recursion.StackImportantQuestions
{
    internal class ImportantRecursionQuestions
    {
        /// <summary>
        /// will print 1 to n 
        /// </summary>
        /// <param name="n"></param>
        public void PrintOneToN(int n) 
        {
            if (n < 1)
                return;
            PrintOneToN(n - 1);
            Console.WriteLine(n);
        }

        /// <summary>
        /// will print n to 1
        /// </summary>
        /// <param name="n"></param>
        public void PrintNtoOne(int n)
        {
            if(n < 1)
                return ;
            Console.WriteLine(n);
            PrintNtoOne(n - 1);
        }

        /// <summary>
        /// Height of the binary tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int HeightOfBinaryTree(TreeNode root)
        {
            if(root == null) // smallest valid input
                return 0;

            return Math.Max(HeightOfBinaryTree(root.left), HeightOfBinaryTree(root.right)) + 1;
        }

        /// <summary>
        /// Sort an array using recursion
        /// </summary>
        /// <param name="nums"></param>
        public void Sort(List<int> nums)
        {
           if(nums.Count == 1) // array is sorted
                return;
           int lastElement = nums[nums.Count - 1]; // reducuing taking last element of the list
           nums.RemoveAt(nums.Count-1); // removing the last element of the list, reducing the input size
           Sort(nums); // sort the array for lesser size of input
           Insert(nums, lastElement);
        }

        private void Insert(List<int> nums, int key)
        {
            if(nums.Count == 0 || nums[nums.Count - 1] <= key)
            {
                nums.Add(key);
                return;
            }
            int val = nums[nums.Count-1];
            nums.RemoveAt(nums.Count - 1);
            Insert(nums, key);
            nums.Add(val);
        }

        /// <summary>
        /// sort stack using recursion
        /// </summary>
        /// <param name="stack"></param>
        public Stack<int> SortStack(Stack<int> stack)
        {
            if (stack.Count == 1)
                return stack;

            int element = stack.Peek();
            stack.Pop();
            stack = SortStack(stack);
            return Insert(stack, element); ;
        }

        /// <summary>
        /// add element into the stack
        /// </summary>
        /// <param name="stack"></param>
        /// <param name="key"></param>
        /// <exception cref="NotImplementedException"></exception>
        private Stack<int> Insert(Stack<int> stack, int key)
        {
           if(stack.Count == 0 || stack.Peek() <= key)
           {
                stack.Push(key);
                return stack;
           }
           int element = stack.Peek();
           stack.Pop();
           stack = Insert(stack, key);
           stack.Push(element);
           return stack;
        }

        public void DeleteMiddleOfTheStack(Stack<int> stack, int k)
        {
            if(k == 1)
            {
                stack.Pop();
                return;
            }
            int top = stack.Pop();
            DeleteMiddleOfTheStack(stack, k - 1);
            stack.Push(top);
        }

        /// <summary>
        /// reverse stack
        /// </summary>
        /// <param name="stack"></param>
        public void ReverseStack(Stack<int> stack)
        {
            if (stack.Count == 1)
                return;
            int top = stack.Pop();
            ReverseStack(stack);
            AddAtBotton(stack, top);
        }

        private void AddAtBotton(Stack<int> stack, int key)
        {
            if(stack.Count == 0)
            {
                stack.Push(key);
                return;
            }
            int element = stack.Pop();
            AddAtBotton(stack, key);
            stack.Push(element);
        }


        public class TreeNode
        {
            public int value;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int value)
            {
                this.value = value;
            }
        }
    }
}
