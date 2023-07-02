namespace BinarySearchTree.BST
{
    internal class BinarySearchTree
    {
        /*
         * Binary search Tree: A Binary Tree that is either empty or has the following properties-
         *  1. All the keys in left subtree of root node are less than the key in the root node
         *  2. All the key in right subtree of root are greater than the key in the root
         *  3. Left and right subtrees of root are also binary search tree
         */
        Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        // In Order traversal of Binary search tree gives elements in ascending order

        /// <summary>
        /// Recursive way to search a key in a BST
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        /// <returns></returns>

        public Node Search(Node root, int key)
        {
            if(root == null)
                return null;

            if(root.info == key)
                return root;
            else if(key < root.info)
                return Search(root.left, key);
            else
                return Search(root.right, key);
        }

        /// <summary>
        /// Iterative way to search an element in a BST
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool SearchIterative(Node root, int key)
        {
            Node curr = root;

            while(curr != null)
            {
                if (key < curr.info)
                    curr = curr.left; // if key is less than current node value, key is present in left subtree
                else if(key > curr.info)
                    curr = curr.right; // if key is greater than current node value, key is present in right subtree
                else
                    return true; // successful search
            }
            return false;
        }


    }
}
