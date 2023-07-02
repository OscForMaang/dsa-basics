namespace BinaryTree.BinaryTree
{
    internal class LevelOrderTraversal
    {
        /// <summary>
        /// Print the node at level n
        /// </summary>
        /// <param name="root"></param>
        public void GetNodeByLevel(Node root, int level)
        {
            if(root == null)
                return;
            if(level == 1)
            {
                Console.WriteLine(root.info + " ");
            }
            GetNodeByLevel(root.left, level - 1);
            GetNodeByLevel(root.right, level - 1);
        }

        /// <summary>
        /// Level order traversal using for loop and recursion 
        /// T: O(N^2)
        /// </summary>
        /// <param name="root"></param>
        public void LevelOrderTraversalUsingLoop(Node root)
        {
            // calculated the height of the tree
            int height = 5;
            for(int  i = 1; i <= height; i++) {
                GetNodeByLevel(root, i);
            }
        }

        /// <summary>
        /// Level order traversal using queue solution, Iterative solution
        /// </summary>
        /// <param name="root"></param>
        public void LevelOrderTraversalUsingQueue(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while(queue.Any())
            {
                Node curr = queue.Dequeue();
                Console.WriteLine($"{curr.info} ");

                if(curr.left != null)
                {
                    queue.Enqueue(curr.left);
                }

                if(curr.right != null)
                {
                    queue.Enqueue(curr.right);
                }
            }
        }


        /// <summary>
        /// Level order traversal using queue solution, Iterative solution
        /// </summary>
        /// <param name="root"></param>
        public void LevelOrderTraversalUsingQueuePrintLevelWise(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            while (queue.Any())
            {
                Node curr = queue.Dequeue();
                if(curr == null)
                {
                    if (!queue.Any())
                        return;
                    queue.Enqueue(null);
                    Console.WriteLine();
                    continue;

                }
                Console.WriteLine($"{curr.info} ");

                if (curr.left != null)
                {
                    queue.Enqueue(curr.left);
                }

                if (curr.right != null)
                {
                    queue.Enqueue(curr.right);
                }
            }
        }
    }
}
