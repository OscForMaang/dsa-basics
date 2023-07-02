namespace BinarySearchTree.BST
{
    internal class MinMaxNodeInBST
    {
        /*
         * Node with smallest Key: 
         *      Last node in the left most path starting from root
         * Node with largest key:
         *      Last node in the right most path starting from root
         */

        /// <summary>
        /// Iterative way to find a node with minimum value in a BST
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MinNode(Node root)
        {
            if(root == null)
            {
                Console.WriteLine("Tree has no element");
                return -1;
            }

            Node curr = root;
            while(curr.left != null)
            {
                curr = curr.left;
            }

            return curr.info;
        }

        /// <summary>
        /// Iterative way tp find a node with Maximum value in a BST
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxNode(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree has no element");
                return -1;
            }

            Node curr = root;
            while (curr.right != null)
            {
                curr = curr.right;
            }

            return curr.info;
        }


        /// <summary>
        /// Recursive way to find the mode with minimum value
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node GetMinNode(Node root)
        {
            if (root.left == null)
                return root;

            return GetMinNode(root.left);
        }

        /// <summary>
        /// Recursive way to find the mode with maximum value
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node GetMaxNode(Node root)
        {
            if (root.left == null)
                return root;

            return GetMaxNode(root.right);
        }
    }
}
